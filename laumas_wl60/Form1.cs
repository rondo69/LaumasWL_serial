using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;

namespace laumas_wl60
{
    public partial class Form1 : Form

    {
        private System.Timers.Timer TTTimer1 = new System.Timers.Timer();// cont. mode
        private System.Timers.Timer TTTimer2 = new System.Timers.Timer();// checkbox ping
        private System.Timers.Timer TTTimer3 = new System.Timers.Timer();// checkbox ping
        private System.Timers.Timer TTTimer4 = new System.Timers.Timer();// stability capture timeout
        private System.Timers.Timer TTTimer5 = new System.Timers.Timer();// for waiting
        History massHist = new History();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
            this.TTTimer1.Interval = 150; // 150ms
            this.TTTimer1.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer1_Elapsed);

            this.TTTimer2.Interval = 350; // 350ms
            this.TTTimer2.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer2_Elapsed);

            this.TTTimer3.Interval = 350; // 350ms
            this.TTTimer3.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer3_Elapsed);

            this.TTTimer4.Interval = 1000;// 1000ms
            this.TTTimer4.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer4_Elapsed);

            this.TTTimer5.Interval = 200; // 200ms
            this.TTTimer5.Elapsed += new System.Timers.ElapsedEventHandler(TTTimer5_Elapsed);
            TTTimer5.Start();
        }

        void TTTimer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)// continuous mode timer
        {
            if (Globals.inhibitTimer1)
            {
                this.BeginInvoke((Action)delegate()
                {
                    IncReadFailCounter();
                });
                return;
            }
            Globals.inhibitTimer1 = true;
            SendCommand("$01n");// we're using read net in cont. mode
        }

        private void TTTimer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)// informal checkbox for ok reply
        {
            TTTimer2.Stop();
            this.BeginInvoke((Action)delegate()
            {
                chbOK.Checked = false;
            });
        }

        private void TTTimer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)// informal checkbox for error reply
        {
            TTTimer3.Stop();
            this.BeginInvoke((Action)delegate()
            {
                chbErr.Checked = false;
            });
        }

        private void TTTimer4_Elapsed(object sender, System.Timers.ElapsedEventArgs e)// used in WaitForStability() method
        {
            Globals.timedLoopExit++;
        }

        private void TTTimer5_Elapsed(object sender, System.Timers.ElapsedEventArgs e)// used in TickWait() method for short pausing
        {
            Globals.myCnt++;
        }

        private void btnReadWeight_Click(object sender, EventArgs e)// read displayed weight
        {
            ReentryPrevent();
            SendCommand("$01t");
        }

        private void btnReadNet_Click(object sender, EventArgs e)// Read net weight
        {
            ReentryPrevent();
            SendCommand("$01n");
        }

        private void btnReadWeightRepeat_Click(object sender, EventArgs e)// continuous mode toggle
        {
            if (string.Compare(lblContStatus.Text, "Stopped") == 0)
            {
                TTTimer1.Start();
                btnCaptureStable.Enabled = true;
                lblContStatus.Text = "Started";
            }
            else
            {
                TTTimer1.Stop();
                btnCaptureStable.Enabled = false;
                lblContStatus.Text = "Stopped";
                lblStabilityIndicator.Visible = false;
                label7.Text = string.Empty;
            }
        }

        private void btnReadSP1_Click(object sender, EventArgs e)// READ SET POINT
        {
            ReentryPrevent();
            SendCommand("$01a");
        }

        private void btnWriteSP1_Click(object sender, EventArgs e)// WRITE SET POINT
        {
            // in production version, you should validate input number better than this
            if (string.Compare(tbWriteSP1.Text, string.Empty) == 0 || tbWriteSP1.Text.Length != 6)
            {
                MessageBox.Show("Not entered, or wrong entered SP value", "Input error");
            }
            else
            {
                ReentryPrevent();
                SendCommand(string.Concat("$01", tbWriteSP1.Text, "A"));
            }
        }

        private void btnZero_Click(object sender, EventArgs e)// ZERO SCALE
        {
            ReentryPrevent();
            SendCommand("$01ZERO");
        }

        private void btnTara_Click(object sender, EventArgs e) // NET -TARE
        {
            ReentryPrevent();         
            SendCommand("$01NET");
        }

        private void btnGross_Click(object sender, EventArgs e)// GROSS - CLEAR TARE
        {
            ReentryPrevent();
            SendCommand("$01GROSS");
        }

        private void SendCommand(string sToScale)// sends command string to scale, calculates chs
        {
            int chs=0;
            int asci=0;
            string sSend;

            foreach (char c in sToScale.Substring(1))
                {
                    asci = (int)c;
                    chs = chs ^ asci;
                }

            sSend = string.Concat(sToScale, chs.ToString("x2").ToUpper(), Convert.ToString((char)13));
            byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes(sSend);

            if (serialPort1.IsOpen)
                {
                    serialPort1.Write(MyMessage, 0, MyMessage.Length);
                    this.BeginInvoke((Action)delegate()
                    {
                        IncWriteCounter();
                    });
                }
            Globals.inhibitTimer1 = false;//returns weigh updating, control to TTTimer1 if in continuous mode
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)// event handler when terminal replies back
        {
            try
            {
                Globals.rxString = serialPort1.ReadTo(Convert.ToString((char)13));
                serialPort1.DiscardInBuffer(); 
                this.BeginInvoke(new EventHandler(DisplayWeight));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Format Error");
            }
        }

        private void DisplayWeight(object sender, EventArgs e)// checks terminal reply, displays weight
        {
            string sFromScale = Globals.rxString;
            string sScaleIntegerPart;
            
            if (sFromScale.IndexOf("&") == -1)
                {
                    IncReadFailCounter();// not a complete string
                }
            else
                {
                    if (string.Compare(sFromScale.Substring(0, 4), "&01#") == 0)// not ok reply - zero over range
                        {
                            chbErr.Checked = true;
                            TTTimer3.Start();
                        }
                    else if (string.Compare(sFromScale.Substring(0, 5), "&&01!") == 0)// ok reply
                        {
                            chbOK.Checked = true;
                            IncReadCounter();
                            TTTimer2.Start();
                        }
                    else if (string.Compare(sFromScale.Substring(0, 5), "&&01?") == 0)// not OK reply
                        {
                            chbErr.Checked = true;
                            TTTimer3.Start();
                        }
                    else if (string.Compare(sFromScale.Substring(0,3), "&01") == 0)// ok reply
                        {
                            chbOK.Checked = true;
                            TTTimer2.Start(); 
                            sScaleIntegerPart = sFromScale.Substring(sFromScale.IndexOf("&") + 3, 6);
                            lblWeight.Text = sScaleIntegerPart;
                            IncReadCounter();
                            if (string.Compare(sFromScale.Substring(9, 1), "t") == 0)
                                { label4.Text="gross";}
                            else if (string.Compare(sFromScale.Substring(9, 1), "n") == 0)
                                { label4.Text = "displayed - net"; } 
                            else 
                                { label4.Text = "SetPoint"; }
                        }
                    massHist.Update(lblWeight.Text);
                    if (massHist.Stablevalues())
                    {
                        lblStabilityIndicator.Visible = false;
                    }
                    else if (string.Compare(lblContStatus.Text, "Stopped") != 0)
                    {
                        lblStabilityIndicator.Visible=true;
                    }
                }
            Globals.inhibitTimer1 = false;// returns weigh updating, control to TTTimer1 if in continuous mode
        }

        private void IncReadFailCounter() //informal counter
        {
            lblCounterReadFail.Text = Convert.ToString(Convert.ToInt32(lblCounterReadFail.Text) + 1);
        }

        private void IncReadCounter()//informal counter
        {
            lblCounterRead.Text = Convert.ToString(Convert.ToInt32(lblCounterRead.Text) + 1);
        }

        private void IncWriteCounter()//informal counter
        {
            lblCounterWrite.Text = Convert.ToString(Convert.ToInt32(lblCounterWrite.Text) + 1);
        }

        private void Initialize()// initial com port parameters
        {
            lblWeight.Text = "000000";
            serialPort1.PortName = tbComP.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.ReceivedBytesThreshold = 4;
            serialPort1.Handshake = Handshake.None;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// closing com port and form
        {
            if (serialPort1.IsOpen)
            {
                e.Cancel = true;
                TTTimer1.Stop();
                TickWait(5);
                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                CloseDown.Start();
                TickWait(5);
            }
        }

        private void CloseSerialOnExit()// closing port in another thread
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Port closing error");
            }
            this.BeginInvoke(new EventHandler(NowCloseForm)); 
        }

        private void NowCloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpP_Click(object sender, EventArgs e)// open port button
        {
            serialPort1.PortName = tbComP.Text;
            if (!serialPort1.IsOpen)
            { 
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    lblPortOpen.Text = string.Concat("Port ", tbComP.Text, " NOT opened");
                    MessageBox.Show(ex.Message, "Port problem");
                    return;
                }
            }
            if (serialPort1.IsOpen)
            {
                lblPortOpen.Text = string.Concat("Port ", tbComP.Text, " opened");
                btnReadWeight.Enabled = true;
                btnReadNet.Enabled = true;
                btnReadWeightRepeat.Enabled = true;
                btnReadSP1.Enabled = true;
                btnWriteSP1.Enabled=true;
                btnZero.Enabled = true;
                btnTara.Enabled = true;
                btnGross.Enabled = true;
                tbComP.Enabled = false;
                btnOpP.Enabled = false;
                lblDemandStatus.Enabled = true;
                lblDemandStatus.Text = "Ready for command";
                lblContStatus.Enabled = true;
                lblPortOpen.Enabled = true;
                lblWeight.Enabled = true;
                lblStableWeight.Enabled = true;
            }
            serialPort1.DiscardInBuffer();
        }


        private void ReentryPrevent()// prevents TTTimer1 from reentry, during possible long operations
        {
            Globals.inhibitTimer1 = true;
            TickWait(2);
        }


        private void WaitForStability()// waits for 6 same weight values or exits after timeuot of 4 secs
        {
            lblCountEnd.Visible = true;
            TTTimer4.Start();
            Globals.timedLoopExit = 0;
            while (!massHist.Stablevalues())
            {
                Application.DoEvents(); 
                //Thread.Sleep(50);
                TickWait(2);
                lblCountEnd.Text = string.Concat("Stability wait count: ", (Globals.timedLoopExit).ToString(), "/4");
                if (Math.Abs(Globals.timedLoopExit) > 4)
                {
                    label7.Text = "stable value on timeout";
                    break;
                }
            }
            if (label7.Text == string.Empty) { label7.Text = "stable value"; }
            TTTimer4.Stop();
            Globals.timedLoopExit = 0;
            lblCountEnd.Visible = false;
        }

        private void btnCaptureStable_Click(object sender, EventArgs e)
        {
            lblStableWeight.Text = "000000";
            label7.Text = "";
            WaitForStability();
            lblStableWeight.Text = massHist.now;
        }

        private void btnClP_Click(object sender, EventArgs e)
        {
            TTTimer1.Stop();          
            TickWait(5);
            Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnButton));
            CloseDown.Start();
        }

        private void CloseSerialOnButton()
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Port closing error");
            }
            this.BeginInvoke(new EventHandler(NowCloseForm)); 
        }

        private void TickWait(int ticks)// waiting for n ticks (1 tick = 200ms)
        {
            int beg;
            int end;
            if (!Globals.twReePrev)
            {
                Globals.twReePrev = true;
                beg = Globals.myCnt;
                end = beg;
                while (Math.Abs(end - beg) < ticks)
                {
                    end = Globals.myCnt;
                }
                Globals.twReePrev = false;
            }
        }

        // weight history 
        public class History
        {
            public string ooooldest;
            public string oooldest;
            public string ooldest;
            public string oldest;
            public string old;
            public string now;

            public void Update(string mass)
            {
                this.ooooldest = this.oooldest;
                this.oooldest = this.ooldest;
                this.ooldest = this.oldest;
                this.oldest = this.old;
                this.old = this.now;
                this.now = mass;
            }

            public bool Stablevalues()
            {
                if (string.Compare(this.ooooldest, this.oooldest) == 0 && string.Compare(this.oooldest, this.ooldest) == 0 
                    && string.Compare(this.ooldest, this.oldest) == 0 && string.Compare(this.oldest, this.old) == 0 
                    && string.Compare(this.old, this.now) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        struct Globals
        {
            public static String rxString = string.Empty;
            public static bool inhibitTimer1 = false;
            public static int timedLoopExit = 0;
            public static int myCnt = 0;
            public static bool twReePrev = false;
        }
    }
}
