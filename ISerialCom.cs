using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiI2cControlCsharp
{
    interface ISerialCom
    {
        void Send(byte[] data, int offset, int count);
        void RegisterToRec(ISerialUpdate observer);
        void UnregisterToRec(ISerialUpdate observer);

        string[] GetAvailableSerialPorts();
        bool SetPort(string com);
        bool SetBaudrate(int baudrate);
        bool SetParity(string com); // E,O,N
        bool SetStopbits(double stopbits); // 1, 1.5, 2

        bool OpenSerialPort();
        void CloseSerialPort();

    }
}
