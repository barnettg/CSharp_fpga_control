using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Diagnostics;

namespace SpiI2cControlCsharp
{
    public class SerialCom : ISerialCom
    {
        /// <summary>
        /// Must be subclassed where the subclass provides the serial protocol and how to notify opservers
        /// </summary>
        SerialPort serialPort1;
        protected List<ISerialUpdate> obsrv = new List<ISerialUpdate>(); // observer to receive decoded modbus packet

        public SerialCom()
        {
            serialPort1 = new SerialPort();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            serialPort1.BaudRate = 57600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
        }
        #region serial receive
        // Serial data recieved handler
        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!serialPort1.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Read all the data waiting in the buffer
            //string data = serialPort1.ReadExisting();
            //foreach (char c in data.ToCharArray())
            //{
            //    string tmp=((int)(c)).ToString("x2");
            //    if (c == MODBUS_ADDRESS) writeToTextDisplayVerbose(Environment.NewLine);
            //    writeToTextDisplayVerbose(tmp+"_");
            //}

            while (serialPort1.BytesToRead > 0)
            {
                // read as byte
                int data = serialPort1.ReadByte();
                string tmp = data.ToString("x2");
                Debug.WriteLine(tmp + "_");

                //notify((Convert.ToChar(data)).ToString());

                // Display the text to the user in the terminal
                //writeToTextDisplayVerbose(data);
                ProcessSerialData(data);
            }
        }

        virtual protected void ProcessSerialData(int data) // override in subclass
        {
            throw new System.InvalidOperationException("Must override ProcessSerialData() in subclass");
        }

        #endregion



        #region ISerialCom
        public void Send(byte[] data, int offset, int count)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(data, offset, count);
            }

        }
        public void RegisterToRec(ISerialUpdate observer)
        {
            obsrv.Add(observer);
        }
        public void UnregisterToRec(ISerialUpdate observer)
        {
            obsrv.Remove(observer);
        }

        public string[] GetAvailableSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }
        public bool SetPort(string com)
        {
            try
            {
                serialPort1.PortName = com;
                return true;
            }
            catch
            {
                Debug.WriteLine("cannot set port name " + com);
            }
            return false;
        }

        public bool SetBaudrate(int baudrate)
        {
            if (baudrate == 9600 || baudrate == 19200 || baudrate == 57600 || baudrate == 115200 || baudrate == 2400 || baudrate == 38400)
            {
                serialPort1.BaudRate = baudrate;
                return true;
            }
            return false;
        }
        public bool SetParity(string com) // E,O,N
        {
            if (com == "E")
            {
                serialPort1.Parity = Parity.Even;
                return true;
            }
            if (com == "O")
            {
                serialPort1.Parity = Parity.Odd;
                return true;
            }
            if (com == "N")
            {
                serialPort1.Parity = Parity.None;
                return true;
            }
            return false;
        }

        public bool SetStopbits(double stopbits) // 1, 1.5, 2
        {
            if (stopbits == 1)
            {
                serialPort1.StopBits = StopBits.One;
                return true;
            }
            if (stopbits == 1.5)
            {
                serialPort1.StopBits = StopBits.OnePointFive;
                return true;
            }
            if (stopbits == 2)
            {
                serialPort1.StopBits = StopBits.Two;
                return true;
            }
            return false;
        }

        public bool OpenSerialPort()
        {
            try
            {
                serialPort1.Open();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Cannot open Port ");
            }
            return false;

        }
        public void CloseSerialPort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
        #endregion
        virtual protected void notify(String message) // override in subclass
        {
            throw new System.InvalidOperationException("Must override notify() in subclass");
            //foreach (ISerialUpdate item in obsrv)
            //{
            //item.Update(packetbuffer, NumberOfPacketBytes);
            //}

        }


    }
}
