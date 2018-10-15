using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiI2cControlCsharp
{
    public partial class MainForm : Form, ISerialUpdate
    {
        ArduinoCommunications arduino;

        public MainForm()
        {
            InitializeComponent();
            btn_Ser_open.Enabled = true;
            btn_Ser_close.Enabled = false;
            arduino = new ArduinoCommunications();
            String[] ports = arduino.GetAvailableSerialPorts();
            foreach (String item in ports)
            {
                cb_SerialPorts.Items.Add(item);
            }
            arduino.RegisterToRec(this);
        }

        public void Update(String message)
        {
            Messageboard(message);
        }
        #region Serial

        private void btn_Ser_open_Click(object sender, EventArgs e)
        {
            Object selectedItem;

            //MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
            //                "Index: " + selectedIndex.ToString());
            //string[] ports = SerialPort.GetPortNames();

            try
            {
                selectedItem = cb_SerialPorts.SelectedItem;
                if (selectedItem != null)
                {
                    ////Debug.WriteLine("Selected Item Text: " + selectedItem.ToString());
                    arduino.SetPort(selectedItem.ToString());

                    bool status = arduino.OpenSerialPort();
                    if (status)
                    {
                        btn_Ser_open.Enabled = false;
                        btn_Ser_close.Enabled = true;
                        Messageboard("Serial Port Open : " + selectedItem.ToString() + Environment.NewLine);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot open Port: ");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Cannot open Port: ");
            }
        }

        private void btn_Ser_close_Click(object sender, EventArgs e)
        {
            arduino.CloseSerialPort();
            btn_Ser_open.Enabled = true;
            btn_Ser_close.Enabled = false;
        }
        #endregion

        #region Messageboard
        private void Messageboard(string mess)
        {
            //tb_chiller_messages.AppendText(mess);

            // if we are not on the same thread that created the textbox we will call the method again
            // this time using Invoke()
            if (this.tb_messages.InvokeRequired == true)
                this.tb_messages.Invoke((MethodInvoker)delegate ()
                {
                    Messageboard(mess);
                });
            else
            {
                //this.label1.Text = text;
                this.tb_messages.AppendText(mess);
            }
        }
        private void btn_Ser_clear_Click(object sender, EventArgs e)
        {
            tb_messages.Clear();
        }
        #endregion

        #region SPI

        private void btn_send_spi_Click(object sender, EventArgs e)
        {
            byte[] outData = new byte[9];

            String add = tb_SpiAddress.Text;
            String dta = tb_spiData.Text;
            int address = 0;
            int send_data = 0;

            try
            {
                address = Convert.ToInt32(add, 16);
                send_data = Convert.ToInt32(dta, 16);
            }
            catch
            {
                MessageBox.Show("Error cannot convert SPI text entry to int");
            }

            outData[0] = (byte)'S';
            //outData[1] = (byte)'W';
            outData[1] = convertToHexChar((address >> 4) & 0xF);
            outData[2] = convertToHexChar(address & 0xF);
            outData[3] = convertToHexChar((send_data >> 12) & 0xF);
            outData[4] = convertToHexChar((send_data >> 8) & 0xF);
            outData[5] = convertToHexChar((send_data >> 4) & 0xF);
            outData[6] = convertToHexChar(send_data & 0xF);
            outData[7] = 13; // CR
            //outData[8] = 10; //LF

            String total_string = "";
            foreach (byte number in outData)
            {
                total_string += Convert.ToChar(number).ToString();
            }
            Messageboard(total_string);

            arduino.Send(outData, 0, 8);
        }

        private void btn_clr_spi_rx_Click(object sender, EventArgs e)
        {
            lbl_spi_rx_data.Text = "-";
        }
        #endregion


        private byte convertToHexChar(int dta)
        {
            if ((dta & 0xF) <= 9)
            {
                return (byte)((dta & 0xF) + '0');
            }
            return (byte)((dta & 0xF) + 'A' - 10);
        }









        #region I2C

        private void btn_i2c_write8_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
