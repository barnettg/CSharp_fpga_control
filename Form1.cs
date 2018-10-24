﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpiI2cControlCsharp
{
    public partial class MainForm : Form, ISerialUpdate
    {
        ArduinoCommunications arduino;
        List<string> receivedData = new List<string>();

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
            receivedData.Add(message);
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



        #region MCP4725 DAC
        // DWXXX<cr>  -- write DAC XXX
        // dwxxx<cr> return 
        private void btn_write_dac_Click(object sender, EventArgs e)
        {
            //byte[] outData = new byte[9];

            String dataStr = tb_write_dac.Text;
            //int send_data = 0;

            while(dataStr.Length<3)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 3) dataStr = "000";

            String total_string = "DW" + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);


            //try
            //{
            //    send_data = Convert.ToInt32(dataStr, 16);
            //}
            //catch
            //{
            //    MessageBox.Show("Error cannot convert DAC text entry to int");
            //}

            //outData[0] = (byte)'D';
            //outData[1] = (byte)'W';
            //outData[2] = convertToHexChar((send_data >> 12) & 0xF);
            //outData[3] = convertToHexChar((send_data >> 8) & 0xF);
            //outData[4] = convertToHexChar((send_data >> 4) & 0xF);
            //outData[5] = convertToHexChar(send_data & 0xF);
            //outData[6] = 13; // CR
            ////outData[8] = 10; //LF

            //String total_string = "";
            //foreach (byte number in outData)
            //{
            //    total_string += Convert.ToChar(number).ToString();
            //}
            //Messageboard(total_string);

            //arduino.Send(outData, 0, 7);


            // get received data



        }

        #endregion

        string  sendTransaction(string data)
        {
            byte[] outData = new byte[9];
            string retStr = "";

            int offset = 0;
            foreach( char item in data)
            {
                outData[offset] = (byte)item;
                offset++;
            }
            outData[offset] = 13; // CR
            arduino.Send(outData, 0, offset+1);

            int sleepCounter = 0;
            while (receivedData.Count == 0)
            {
                sleepCounter++;
                if (sleepCounter > 20) break; //waited long enough
                Thread.Sleep(50); // milliseconds
            }

            if (receivedData.Count > 0)
            {
                retStr = receivedData[0];
                receivedData.RemoveAt(0);
            }

            return retStr;
        }

        #region AMC7812
        private void btn_7812_write_reg_Click(object sender, EventArgs e)
        {
            String dataStr = tb_7812_write_reg_data.Text;
            String reg = tb_7812_write_reg_reg.Text;

            while (dataStr.Length < 4)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 4) dataStr = "0000";

            while (reg.Length < 2)
            {
                reg = "0" + reg;
            }
            if (reg.Length > 2) reg = "00";


            String total_string = "AW" + reg + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_read_reg_Click(object sender, EventArgs e)
        {
            String reg = tb_7812_read_reg_reg.Text;

            while (reg.Length < 2)
            {
                reg = "0" + reg;
            }
            if (reg.Length > 2) reg = "00";


            String total_string = "AR" + reg;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_set_DAC_Click(object sender, EventArgs e)
        {
            String dataStr = tb_7812_set_dac_data.Text;
            String num = tb_7812_set_dac_num.Text;

            while (dataStr.Length < 3)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 3) dataStr = "000";

            while (num.Length < 1)
            {
                num = "0" + num;
            }
            if (num.Length > 1) num = "0";


            String total_string = "AD" + num + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_read_ADC_Click(object sender, EventArgs e)
        {
            String num = tb_7812_read_adc_num.Text;

            while (num.Length < 1)
            {
                num = "0" + num;
            }
            if (num.Length > 1) num = "00";


            String total_string = "AA" + num;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_write_config0_Click(object sender, EventArgs e)
        {
            // config 0 reg address 0x4C   
            String dataStr = tb_7812_write_conf0_data.Text;

            while (dataStr.Length < 4)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 4) dataStr = "0000";

            String total_string = "AW4C" + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);

        }

        private void btn_7812_write_config1_Click(object sender, EventArgs e)
        {
            // config 1 reg address 0x4D
            String dataStr = tb_7812_write_conf1_data.Text;

            while (dataStr.Length < 4)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 4) dataStr = "0000";

            String total_string = "AW4D" + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_write_gpio_Click(object sender, EventArgs e)
        {
            String dataStr = tb_7812_write_gpio_data.Text;

            while (dataStr.Length < 2)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 2) dataStr = "00";

            String total_string = "AGW" + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_read_gpio_Click(object sender, EventArgs e)
        {
            String total_string = "AGR";
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_7812_initialize_Click(object sender, EventArgs e)
        {
            String total_string = "AI";
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }
        #endregion


        #region MPC23017
        private void btn_23017_write_reg_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            // reg tb_23017_write_reg_reg
            // data  tb_23017_write_reg_data

            String dataStr = tb_23017_write_reg_data.Text;
            String reg = tb_23017_write_reg_reg.Text;
            String id = tb_23017_ID.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            while (dataStr.Length < 2)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 2) dataStr = "00";

            while (reg.Length < 2)
            {
                reg = "0" + reg;
            }
            if (reg.Length > 2) reg = "00";


            String total_string = "GW" + id + reg + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_read_reg_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            // reg tb_23017_read_reg_reg

            String reg = tb_23017_read_reg_reg.Text;
            String id = tb_23017_ID.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            while (reg.Length < 2)
            {
                reg = "0" + reg;
            }
            if (reg.Length > 2) reg = "00";


            String total_string = "GR" + id + reg;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_read_porta_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            String total_string = "GAR" + id ;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_read_portb_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            String total_string = "GBR" + id;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_write_porta_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            String dataStr = tb_23017_write_porta_data.Text;

            while (dataStr.Length < 2)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 2) dataStr = "00";

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            String total_string = "GAW" + id + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_write_portb_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            String dataStr = tb_23017_write_portb_data.Text;

            while (dataStr.Length < 2)
            {
                dataStr = "0" + dataStr;
            }
            if (dataStr.Length > 2) dataStr = "00";

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            String total_string = "GBW" + id + dataStr;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }

        private void btn_23017_initialize_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            String total_string = "GI" + id;
            Messageboard(total_string);
            string results = sendTransaction(total_string);
            Messageboard("rec: " + results);
        }
        #endregion
    }
}
