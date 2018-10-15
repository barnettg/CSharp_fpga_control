using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiI2cControlCsharp
{
    class ArduinoCommunications : SerialCom
    {

        //int[] recData = new int[256];
        List<char> recData = new List<char>();
        int topPointer = 0;
        byte[] outData = new byte[100];

        override protected void ProcessSerialData(int data) // perform protocol
        {

            Debug.WriteLine("ProcessSerialData: " + Convert.ToChar(data).ToString());
            recData.Add(Convert.ToChar(data));
            //topPointer++;
            if (data == 13) // end found
            {
                DecodePacket();
                // empty the packet
                //topPointer = 0;
            }
        }

        override protected void notify(String message) // send a completed received packet to whatever wants it
        {
            //char[] dataOut = { 'H', 'E', 'L', 'L', 'O' };
            Debug.WriteLine("notify");
            foreach (ISerialUpdate item in obsrv)
            {
                item.Update(message);
            }

        }

        #region receive packets
        private void DecodePacket()
        {
            // expect data in recData array up to a 13(LF)
            Debug.WriteLine("DecodePacket");
            String totalString = "";
            foreach (char item in recData)
            {
                if (item == 13) break;
                totalString += item.ToString();

            }
            notify(totalString);
            if (recData[0] == 's')
            {
                Debug.WriteLine("found s");
                // convert to string

                //foreach(char item in recData)
                //{
                //    if (item == 13) break;
                //    totalString += item.ToString();

                //}
                //notify(totalString);

            }


            recData.Clear();

        }

        private int ConvertHexcharToInt(int data)
        {
            if (data >= '0' && data <= '9')
            {
                return (int)(data - '0');
            }
            else if (data >= 'a' && data <= 'f')
            {
                return (int)(data - 'a' + 10);
            }
            else if (data >= 'A' && data <= 'F')
            {
                return (int)(data - 'A' + 10);
            }
            return 0;
        }

        #endregion

    }
}
