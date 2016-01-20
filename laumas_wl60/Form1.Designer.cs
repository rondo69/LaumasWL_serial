namespace laumas_wl60
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStabilityIndicator = new System.Windows.Forms.Label();
            this.lblStableWeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbErr = new System.Windows.Forms.CheckBox();
            this.chbOK = new System.Windows.Forms.CheckBox();
            this.lblCounterReadFail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCounterRead = new System.Windows.Forms.Label();
            this.lblCounterWrite = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblContStatus = new System.Windows.Forms.Label();
            this.btnReadWeightRepeat = new System.Windows.Forms.Button();
            this.btnCaptureStable = new System.Windows.Forms.Button();
            this.lblCountEnd = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDemandStatus = new System.Windows.Forms.Label();
            this.tbWriteSP1 = new System.Windows.Forms.TextBox();
            this.btnReadNet = new System.Windows.Forms.Button();
            this.btnGross = new System.Windows.Forms.Button();
            this.btnTara = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnWriteSP1 = new System.Windows.Forms.Button();
            this.btnReadSP1 = new System.Windows.Forms.Button();
            this.btnReadWeight = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpP = new System.Windows.Forms.Button();
            this.tbComP = new System.Windows.Forms.TextBox();
            this.lblPortOpen = new System.Windows.Forms.Label();
            this.btnClP = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 75;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 600;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblStabilityIndicator);
            this.groupBox1.Controls.Add(this.lblStableWeight);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 121);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(216, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 31);
            this.label7.TabIndex = 39;
            this.label7.Text = "  ";
            // 
            // lblStabilityIndicator
            // 
            this.lblStabilityIndicator.AutoSize = true;
            this.lblStabilityIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStabilityIndicator.Location = new System.Drawing.Point(9, 25);
            this.lblStabilityIndicator.Name = "lblStabilityIndicator";
            this.lblStabilityIndicator.Size = new System.Drawing.Size(32, 25);
            this.lblStabilityIndicator.TabIndex = 38;
            this.lblStabilityIndicator.Text = " ~";
            this.lblStabilityIndicator.Visible = false;
            // 
            // lblStableWeight
            // 
            this.lblStableWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStableWeight.AutoSize = true;
            this.lblStableWeight.Enabled = false;
            this.lblStableWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStableWeight.ForeColor = System.Drawing.Color.Blue;
            this.lblStableWeight.Location = new System.Drawing.Point(71, 70);
            this.lblStableWeight.Name = "lblStableWeight";
            this.lblStableWeight.Size = new System.Drawing.Size(110, 31);
            this.lblStableWeight.TabIndex = 37;
            this.lblStableWeight.Text = "000000";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.AutoSize = true;
            this.lblWeight.Enabled = false;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWeight.ForeColor = System.Drawing.Color.Blue;
            this.lblWeight.Location = new System.Drawing.Point(71, 25);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(110, 31);
            this.lblWeight.TabIndex = 36;
            this.lblWeight.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(216, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "immediate value";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chbErr);
            this.groupBox2.Controls.Add(this.chbOK);
            this.groupBox2.Controls.Add(this.lblCounterReadFail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCounterRead);
            this.groupBox2.Controls.Add(this.lblCounterWrite);
            this.groupBox2.Location = new System.Drawing.Point(577, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 368);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Replies:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Counters:";
            // 
            // chbErr
            // 
            this.chbErr.AutoSize = true;
            this.chbErr.Enabled = false;
            this.chbErr.Location = new System.Drawing.Point(18, 142);
            this.chbErr.Name = "chbErr";
            this.chbErr.Size = new System.Drawing.Size(64, 17);
            this.chbErr.TabIndex = 32;
            this.chbErr.Text = "Err reply";
            this.chbErr.UseVisualStyleBackColor = true;
            // 
            // chbOK
            // 
            this.chbOK.AutoSize = true;
            this.chbOK.Enabled = false;
            this.chbOK.Location = new System.Drawing.Point(18, 98);
            this.chbOK.Name = "chbOK";
            this.chbOK.Size = new System.Drawing.Size(66, 17);
            this.chbOK.TabIndex = 31;
            this.chbOK.Text = "OK reply";
            this.chbOK.UseVisualStyleBackColor = true;
            // 
            // lblCounterReadFail
            // 
            this.lblCounterReadFail.AutoSize = true;
            this.lblCounterReadFail.Location = new System.Drawing.Point(75, 280);
            this.lblCounterReadFail.Name = "lblCounterReadFail";
            this.lblCounterReadFail.Size = new System.Drawing.Size(13, 13);
            this.lblCounterReadFail.TabIndex = 30;
            this.lblCounterReadFail.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reentry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Read:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Write:";
            // 
            // lblCounterRead
            // 
            this.lblCounterRead.AutoSize = true;
            this.lblCounterRead.Location = new System.Drawing.Point(75, 251);
            this.lblCounterRead.Name = "lblCounterRead";
            this.lblCounterRead.Size = new System.Drawing.Size(13, 13);
            this.lblCounterRead.TabIndex = 26;
            this.lblCounterRead.Text = "0";
            // 
            // lblCounterWrite
            // 
            this.lblCounterWrite.AutoSize = true;
            this.lblCounterWrite.Location = new System.Drawing.Point(75, 222);
            this.lblCounterWrite.Name = "lblCounterWrite";
            this.lblCounterWrite.Size = new System.Drawing.Size(13, 13);
            this.lblCounterWrite.TabIndex = 25;
            this.lblCounterWrite.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.lblContStatus);
            this.groupBox3.Controls.Add(this.btnReadWeightRepeat);
            this.groupBox3.Controls.Add(this.btnCaptureStable);
            this.groupBox3.Controls.Add(this.lblCountEnd);
            this.groupBox3.Location = new System.Drawing.Point(24, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 122);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Continuous mode controls";
            // 
            // lblContStatus
            // 
            this.lblContStatus.AutoSize = true;
            this.lblContStatus.Enabled = false;
            this.lblContStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContStatus.ForeColor = System.Drawing.Color.Green;
            this.lblContStatus.Location = new System.Drawing.Point(181, 32);
            this.lblContStatus.Name = "lblContStatus";
            this.lblContStatus.Size = new System.Drawing.Size(67, 16);
            this.lblContStatus.TabIndex = 32;
            this.lblContStatus.Text = "Stopped";
            // 
            // btnReadWeightRepeat
            // 
            this.btnReadWeightRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnReadWeightRepeat.Enabled = false;
            this.btnReadWeightRepeat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReadWeightRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReadWeightRepeat.Location = new System.Drawing.Point(12, 32);
            this.btnReadWeightRepeat.Name = "btnReadWeightRepeat";
            this.btnReadWeightRepeat.Size = new System.Drawing.Size(150, 32);
            this.btnReadWeightRepeat.TabIndex = 28;
            this.btnReadWeightRepeat.Text = "Start/Stop continuous";
            this.btnReadWeightRepeat.UseVisualStyleBackColor = false;
            this.btnReadWeightRepeat.Click += new System.EventHandler(this.btnReadWeightRepeat_Click);
            // 
            // btnCaptureStable
            // 
            this.btnCaptureStable.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureStable.Enabled = false;
            this.btnCaptureStable.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCaptureStable.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCaptureStable.Location = new System.Drawing.Point(12, 73);
            this.btnCaptureStable.Name = "btnCaptureStable";
            this.btnCaptureStable.Size = new System.Drawing.Size(150, 32);
            this.btnCaptureStable.TabIndex = 31;
            this.btnCaptureStable.Text = "Capture stable";
            this.btnCaptureStable.UseVisualStyleBackColor = false;
            this.btnCaptureStable.Click += new System.EventHandler(this.btnCaptureStable_Click);
            // 
            // lblCountEnd
            // 
            this.lblCountEnd.AutoSize = true;
            this.lblCountEnd.Location = new System.Drawing.Point(181, 73);
            this.lblCountEnd.Name = "lblCountEnd";
            this.lblCountEnd.Size = new System.Drawing.Size(118, 13);
            this.lblCountEnd.TabIndex = 30;
            this.lblCountEnd.Text = "Stability wait count: 0/4";
            this.lblCountEnd.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.lblDemandStatus);
            this.groupBox4.Controls.Add(this.tbWriteSP1);
            this.groupBox4.Controls.Add(this.btnReadNet);
            this.groupBox4.Controls.Add(this.btnGross);
            this.groupBox4.Controls.Add(this.btnTara);
            this.groupBox4.Controls.Add(this.btnZero);
            this.groupBox4.Controls.Add(this.btnWriteSP1);
            this.groupBox4.Controls.Add(this.btnReadSP1);
            this.groupBox4.Controls.Add(this.btnReadWeight);
            this.groupBox4.Location = new System.Drawing.Point(24, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 240);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Demand mode controls";
            // 
            // lblDemandStatus
            // 
            this.lblDemandStatus.AutoSize = true;
            this.lblDemandStatus.Enabled = false;
            this.lblDemandStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDemandStatus.ForeColor = System.Drawing.Color.Green;
            this.lblDemandStatus.Location = new System.Drawing.Point(181, 14);
            this.lblDemandStatus.Name = "lblDemandStatus";
            this.lblDemandStatus.Size = new System.Drawing.Size(67, 16);
            this.lblDemandStatus.TabIndex = 33;
            this.lblDemandStatus.Text = "Stopped";
            // 
            // tbWriteSP1
            // 
            this.tbWriteSP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWriteSP1.Location = new System.Drawing.Point(168, 193);
            this.tbWriteSP1.Name = "tbWriteSP1";
            this.tbWriteSP1.Size = new System.Drawing.Size(93, 20);
            this.tbWriteSP1.TabIndex = 28;
            this.tbWriteSP1.Text = "000100";
            // 
            // btnReadNet
            // 
            this.btnReadNet.BackColor = System.Drawing.Color.Transparent;
            this.btnReadNet.Enabled = false;
            this.btnReadNet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReadNet.Location = new System.Drawing.Point(6, 81);
            this.btnReadNet.Name = "btnReadNet";
            this.btnReadNet.Size = new System.Drawing.Size(150, 32);
            this.btnReadNet.TabIndex = 27;
            this.btnReadNet.Text = "Read Displayed - Net";
            this.btnReadNet.UseVisualStyleBackColor = false;
            this.btnReadNet.Click += new System.EventHandler(this.btnReadNet_Click);
            // 
            // btnGross
            // 
            this.btnGross.Enabled = false;
            this.btnGross.Location = new System.Drawing.Point(346, 81);
            this.btnGross.Name = "btnGross";
            this.btnGross.Size = new System.Drawing.Size(150, 32);
            this.btnGross.TabIndex = 26;
            this.btnGross.Text = "Show Gross (Clear tare)";
            this.btnGross.UseVisualStyleBackColor = true;
            this.btnGross.Click += new System.EventHandler(this.btnGross_Click);
            // 
            // btnTara
            // 
            this.btnTara.Enabled = false;
            this.btnTara.Location = new System.Drawing.Point(346, 40);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(150, 32);
            this.btnTara.TabIndex = 25;
            this.btnTara.Text = "Show Net (Tare scale)";
            this.btnTara.UseVisualStyleBackColor = true;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // btnZero
            // 
            this.btnZero.Enabled = false;
            this.btnZero.Location = new System.Drawing.Point(168, 40);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(150, 32);
            this.btnZero.TabIndex = 24;
            this.btnZero.Text = "Zero";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnWriteSP1
            // 
            this.btnWriteSP1.Enabled = false;
            this.btnWriteSP1.Location = new System.Drawing.Point(6, 193);
            this.btnWriteSP1.Name = "btnWriteSP1";
            this.btnWriteSP1.Size = new System.Drawing.Size(150, 32);
            this.btnWriteSP1.TabIndex = 23;
            this.btnWriteSP1.Text = "Write SP1 (6 digits)";
            this.btnWriteSP1.UseVisualStyleBackColor = true;
            this.btnWriteSP1.Click += new System.EventHandler(this.btnWriteSP1_Click);
            // 
            // btnReadSP1
            // 
            this.btnReadSP1.Enabled = false;
            this.btnReadSP1.Location = new System.Drawing.Point(6, 146);
            this.btnReadSP1.Name = "btnReadSP1";
            this.btnReadSP1.Size = new System.Drawing.Size(150, 32);
            this.btnReadSP1.TabIndex = 22;
            this.btnReadSP1.Text = "Read SP1";
            this.btnReadSP1.UseVisualStyleBackColor = true;
            this.btnReadSP1.Click += new System.EventHandler(this.btnReadSP1_Click);
            // 
            // btnReadWeight
            // 
            this.btnReadWeight.Enabled = false;
            this.btnReadWeight.Location = new System.Drawing.Point(6, 40);
            this.btnReadWeight.Name = "btnReadWeight";
            this.btnReadWeight.Size = new System.Drawing.Size(150, 32);
            this.btnReadWeight.TabIndex = 21;
            this.btnReadWeight.Text = "Read Gross";
            this.btnReadWeight.UseVisualStyleBackColor = true;
            this.btnReadWeight.Click += new System.EventHandler(this.btnReadWeight_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.btnOpP);
            this.groupBox5.Controls.Add(this.tbComP);
            this.groupBox5.Controls.Add(this.lblPortOpen);
            this.groupBox5.Controls.Add(this.btnClP);
            this.groupBox5.Location = new System.Drawing.Point(24, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(723, 60);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Com port controls";
            // 
            // btnOpP
            // 
            this.btnOpP.ForeColor = System.Drawing.Color.Green;
            this.btnOpP.Location = new System.Drawing.Point(12, 19);
            this.btnOpP.Name = "btnOpP";
            this.btnOpP.Size = new System.Drawing.Size(150, 32);
            this.btnOpP.TabIndex = 43;
            this.btnOpP.Text = "Open port :";
            this.btnOpP.UseVisualStyleBackColor = true;
            this.btnOpP.Click += new System.EventHandler(this.btnOpP_Click);
            // 
            // tbComP
            // 
            this.tbComP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbComP.Location = new System.Drawing.Point(184, 31);
            this.tbComP.Name = "tbComP";
            this.tbComP.Size = new System.Drawing.Size(57, 20);
            this.tbComP.TabIndex = 42;
            this.tbComP.Text = "COM8";
            this.tbComP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPortOpen
            // 
            this.lblPortOpen.AutoSize = true;
            this.lblPortOpen.Enabled = false;
            this.lblPortOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPortOpen.ForeColor = System.Drawing.Color.Green;
            this.lblPortOpen.Location = new System.Drawing.Point(266, 31);
            this.lblPortOpen.Name = "lblPortOpen";
            this.lblPortOpen.Size = new System.Drawing.Size(87, 16);
            this.lblPortOpen.TabIndex = 41;
            this.lblPortOpen.Text = "Port closed";
            // 
            // btnClP
            // 
            this.btnClP.ForeColor = System.Drawing.Color.Red;
            this.btnClP.Location = new System.Drawing.Point(438, 19);
            this.btnClP.Name = "btnClP";
            this.btnClP.Size = new System.Drawing.Size(150, 32);
            this.btnClP.TabIndex = 40;
            this.btnClP.Text = "Close port  and exit";
            this.btnClP.UseVisualStyleBackColor = true;
            this.btnClP.Click += new System.EventHandler(this.btnClP_Click);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 50;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(769, 601);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Laumas WL60 comm demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStableWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbErr;
        private System.Windows.Forms.CheckBox chbOK;
        private System.Windows.Forms.Label lblCounterReadFail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCounterRead;
        private System.Windows.Forms.Label lblCounterWrite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReadWeightRepeat;
        private System.Windows.Forms.Button btnCaptureStable;
        private System.Windows.Forms.Label lblCountEnd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReadNet;
        private System.Windows.Forms.Button btnGross;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnWriteSP1;
        private System.Windows.Forms.Button btnReadSP1;
        private System.Windows.Forms.Button btnReadWeight;
        private System.Windows.Forms.TextBox tbWriteSP1;
        private System.Windows.Forms.Label lblContStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOpP;
        private System.Windows.Forms.TextBox tbComP;
        private System.Windows.Forms.Label lblPortOpen;
        private System.Windows.Forms.Button btnClP;
        private System.Windows.Forms.Label lblDemandStatus;
        private System.Windows.Forms.Label lblStabilityIndicator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer5;
    }
}

