using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assetto_Corsa_Manager
{

    class ArduinoCOM
    {
        bool isConnected = false;
        public String[] ports;
        SerialPort port;


        public void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        public void connectToArduino(string SPort)
        {
            isConnected = true;
            port = new SerialPort(SPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
       
        }

        
        public void disconnectFromArduino()
        {
            isConnected = false;
            
            port.Close();
        }

        public void send(string data)
        {

            port.Write(data);
        }

    }
    
}
