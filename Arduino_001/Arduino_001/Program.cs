using System;
using System.IO.Ports;

namespace test
{
    class Program
    {
        static SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        static void Main(string[] args)
        {
            //Set the datareceived event handler
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            //Open the serial port
            sp.Open();
            //Read from the console, to stop it from closing.
            Console.Read();
        }
        static void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Write the serial port data to the console.
            Console.Write(sp.ReadExisting());
        }
    }
}
