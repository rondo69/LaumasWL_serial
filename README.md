# Laumas WL60 weigh scale terminal - serial communication demo

This is a [Sandstorm](http://sandstorm.io) app originally created in one day.
It is primarily a mash-up of three things:

This is my implementation of a simple program communicating via serial port with [Laumas WL60] (http://www.laumas.com/en/prodotti_scheda.php?iDP=264).

It's done in C# and it supports:
* continuous reading of weight
* on demand read of displayed/gross weight
* on demand zero and tare scale
* on demand writing and reading of set points
* display switchover tare/net/gross
* capture stable value based on (n same subsequent weight values) or (timeout m seconds) 

There are 4 main methods used once when com port is opened:
* TTTimer1_Elapsed() emulates continuous mode
* SendCommand(string) appends the checksum characters and sends the command string
* serialPort1_DataReceived_1() event handler when terminal responds
* DisplayWeight() parses terminal reply and updates weight

# Note
This is not production version, it is excerpt from bigger program utilizing WL60.
You are free to use all or part of the project. 

