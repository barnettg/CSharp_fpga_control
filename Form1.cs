using System;
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
            tabControl1.TabPages.Remove(tabPage_genericI2C); 
        }

        public void Update(String message)
        {
            Messageboard("\r\nupdate: " + message);
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

        string sendTransaction(string data)
        {
            Messageboard("\r\nsendTransaction: " + data);

            byte[] outData = new byte[9];
            string retStr = "";

            int offset = 0;
            foreach (char item in data)
            {
                outData[offset] = (byte)item;
                offset++;
            }
            outData[offset] = 13; // CR

            receivedData.Clear(); // clear the rec buffer to sync up data

            arduino.Send(outData, 0, offset + 1);

            int sleepCounter = 0;
            while (receivedData.Count == 0)
            {
                Application.DoEvents();  // do this because serial rec is not a thread
                sleepCounter++;
                if (sleepCounter > 20) break; //waited long enough
                Thread.Sleep(50); // milliseconds
            }

            if (receivedData.Count > 0)
            {
                retStr = receivedData[0];
                receivedData.RemoveAt(0);
            }
            Messageboard("\r\nsendTransaction rec: " + retStr);
            retStr = retStr.Trim(); // picking up erroneous \n
            return retStr;
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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);


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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
        }

        private void btn_7812_read_reg_Click(object sender, EventArgs e)
        {
            String reg = tb_7812_read_reg_reg.Text;
            lbl_7812_read_reg_data.Text = "-";

            while (reg.Length < 2)
            {
                reg = "0" + reg;
            }
            if (reg.Length > 2) reg = "00";


            String total_string = "AR" + reg;
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            results = results.Trim();
            // format  arRRDDDD 16-bit hex  DDDD  
            if (results.Length >= 7)
            {
                lbl_7812_read_reg_data.Text = results.Substring(4, 4);
            }
            //Messageboard("\r\nrec: " + results);
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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
        }

        private void btn_7812_read_ADC_Click(object sender, EventArgs e)
        {
            String num = tb_7812_read_adc_num.Text;
            lbl_7812_read_adc_data.Text = "-";


            while (num.Length < 1)
            {
                num = "0" + num;
            }
            if (num.Length > 1) num = "00";


            String total_string = "AA" + num;
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            results = results.Trim();
            // format  aanDDD 12-bit hex  DDD  
            if (results.Length >= 6)
            {
                lbl_7812_read_adc_data.Text = results.Substring(3, 3);
            }
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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);

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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
        }

        private void btn_7812_read_gpio_Click(object sender, EventArgs e)
        {
            String total_string = "AGR";
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
        }

        private void btn_7812_initialize_Click(object sender, EventArgs e)
        {
            String total_string = "AI";
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
           // Messageboard("\r\nrec: " + results);
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
            //Messageboard("\r\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\r\nrec: " + results);
        }

        private void btn_23017_read_reg_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            // reg tb_23017_read_reg_reg

            String reg = tb_23017_read_reg_reg.Text;
            String id = tb_23017_ID.Text;
            lbl_23017_read_reg_data.Text = "-";

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
            //Messageboard("\n" + total_string);
            string results = sendTransaction(total_string);
            results = results.Trim();
            // format grnrrdd   with data  DD(8-bit hex) 
            if (results.Length >= 7)
            {
                lbl_23017_read_reg_data.Text = results.Substring(5, 2);
            }
        }

        private void btn_23017_read_porta_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            lbl_23017_read_porta_data.Text = "-";

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            if(cb_use_bit_read_porta.Checked)
            {
                // single bit
                //   send GXARNZ<cr>  read device N(0-5) port A bit Z
                //    rec back gxarnzD   with data  D(1-bit hex) 
                String bitNumber = tb_bit_num_rd_porta.Text;
                if (bitNumber.Length != 1) bitNumber = "0";

                String total_string = "GXAR" + id + bitNumber;
                string results = sendTransaction(total_string);
                if (results.Length >= 7)
                {
                    lbl_23017_read_porta_data.Text = results.Substring(6, 1);
                }

            }
            else
            { 
                String total_string = "GAR" + id ;
               // Messageboard("\n" + total_string);
                string results = sendTransaction(total_string);
                results = results.Trim();
                // format garNDD  wher N is device ID and DD is hex data
                if(results.Length>=6)
                {
                    lbl_23017_read_porta_data.Text = results.Substring(4,2);
                }
                    //Messageboard("\nrec: " + results);
            }
        }

        private void btn_23017_read_portb_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            lbl_23017_read_portb_data.Text = "-";

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            if (cb_use_bit_read_portb.Checked)
            {
                // single bit
                //   send GXBRNZ<cr>  read device N(0-5) port B bit Z
                //    rec back gxbrnzD   with data  D(1-bit hex) 
                String bitNumber = tb_bit_num_rd_portb.Text;
                if (bitNumber.Length != 1) bitNumber = "0";

                String total_string = "GXBR" + id + bitNumber;
                string results = sendTransaction(total_string);
                if (results.Length >= 7)
                {
                    lbl_23017_read_portb_data.Text = results.Substring(6, 1);
                }

            }
            else
            {

                String total_string = "GBR" + id;
                //Messageboard("\n" + total_string);
                string results = sendTransaction(total_string);
                results = results.Trim();
                // format gbrNDD  wher N is device ID and DD is hex data
                if (results.Length >= 6)
                {
                    lbl_23017_read_portb_data.Text = results.Substring(4, 2);
                }
            }
        }

        private void btn_23017_write_porta_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            String dataStr = tb_23017_write_porta_data.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            if (cb_use_bit_write_porta.Checked)
            {
                // single bit
                //   send GXAWNZD<cr>  write device N(0-5) port A bit Z with data D(1-bit hex) 
                //    rec back gxawnzD   
                String bitNumber = tb_bit_num_wr_porta.Text;
                if (bitNumber.Length != 1) bitNumber = "0";
                if (dataStr.Length != 1) dataStr = "0";

                String total_string = "GXAW" + id + bitNumber + dataStr;
                string results = sendTransaction(total_string);

            }
            else
            {
                //   send GAWNDD<cr>  write device N(0-5) port A with data  DD(8-bit hex) 
                //    rec back gawnDD   
                while (dataStr.Length < 2)
                {
                    dataStr = "0" + dataStr;
                }
                if (dataStr.Length > 2) dataStr = "00";

                String total_string = "GAW" + id + dataStr;
                //Messageboard("\n" + total_string);
                string results = sendTransaction(total_string);
                //Messageboard("\nrec: " + results);
            }
        }

        private void btn_23017_write_portb_Click(object sender, EventArgs e)
        {
            // ID tb_23017_ID
            String id = tb_23017_ID.Text;
            String dataStr = tb_23017_write_portb_data.Text;

            while (id.Length < 1)
            {
                id = "0" + id;
            }
            if (id.Length > 1) id = "0";

            if (cb_use_bit_write_portb.Checked)
            {
                // single bit
                //   send GXBWNZD<cr>  write device N(0-5) port A bit Z with data D(1-bit hex) 
                //    rec back gxbwnzD   
                String bitNumber = tb_bit_num_wr_portb.Text;
                if (bitNumber.Length != 1) bitNumber = "0";
                if (dataStr.Length != 1) dataStr = "0";

                String total_string = "GXBW" + id + bitNumber + dataStr;
                string results = sendTransaction(total_string);

            }
            else
            {
                //   send GBWNDD<cr>  read device N(0-5) port B with data  DD(8-bit hex) 
                //    rec back gbwnDD  
                while (dataStr.Length < 2)
                {
                    dataStr = "0" + dataStr;
                }
                if (dataStr.Length > 2) dataStr = "00";

                String total_string = "GBW" + id + dataStr;
                //Messageboard("\n" + total_string);
                string results = sendTransaction(total_string);
                //Messageboard("\nrec: " + results);
            }
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
            //Messageboard("\n" + total_string);
            string results = sendTransaction(total_string);
            //Messageboard("\nrec: " + results);
        }
        #endregion

        private void btn_setup_basic_conf_Click(object sender, EventArgs e)
        {

        }

        private void btn_set_pds_ave_v_Click(object sender, EventArgs e)
        {
            string val = tb_set_pds_ave_v.Text;
            double number = 0;
            Double.TryParse(val, out number);
            // set AMC7812  dac #2 12-bit hex value

            int dacData = (int)(number * 4095 / 5.0);
            string dataStr = dacData.ToString("X3");

            String total_string = "AD2" + dataStr;
            string results = sendTransaction(total_string);
        }

        private void btn_set_pd1_ave_v_Click(object sender, EventArgs e)
        {
            string val = tb_set_pd1_ave_v.Text;
            double number = 0;
            Double.TryParse(val, out number);
            // set AMC7812  dac #3 12-bit hex value

            int dacData = (int)(number * 4095 / 5.0);
            string dataStr = dacData.ToString("X3");

            String total_string = "AD3" + dataStr;
            string results = sendTransaction(total_string);
        }

        private void btn_set_pd2_ave_v_Click(object sender, EventArgs e)
        {
            string val = tb_set_pd2_ave_v.Text;
            double number = 0;
            Double.TryParse(val, out number);
            // set AMC7812  dac #8 12-bit hex value

            int dacData = (int)(number * 4095 / 5.0);
            string dataStr = dacData.ToString("X3");

            String total_string = "AD8" + dataStr;
            string results = sendTransaction(total_string);
        }

        private void btn_set_pd3_ave_v_Click(object sender, EventArgs e)
        {
            string val = tb_set_pd3_ave_v.Text;
            double number = 0;
            Double.TryParse(val, out number);
            // set AMC7812  dac #7 12-bit hex value

            int dacData = (int)(number * 4095 / 5.0);
            string dataStr = dacData.ToString("X3");

            String total_string = "AD7" + dataStr;
            string results = sendTransaction(total_string);
        }

        private void btn_set_humidity_percent_Click(object sender, EventArgs e)
        {
            string val = tb_set_humidity_percent.Text;
            double number = 0;
            Double.TryParse(val, out number);
            // set AMC7812  dac #10 12-bit hex value

            int dacData = (int)(number * 4095 / 5.0); //  need to check humidity device for 100% voltage
            string dataStr = dacData.ToString("X3");

            String total_string = "ADA" + dataStr;
            string results = sendTransaction(total_string);
        }

        private void btn_read_recirc_Click(object sender, EventArgs e)
        {
            // MCP23017 0x20 port b bit 2
            // lbl_read_recirc   recirc: 

            // --------------------------- need protocol for bits ------------------------


        }

        private void btn_read_indicator_Click(object sender, EventArgs e)
        {
            // MCP23017 0x22 port B bits 4 and/or 5 
            // lbl_indicator   Indicator:
        }

        private void cb_keyOn_CheckedChanged(object sender, EventArgs e)
        {
            //MCP23017 0x21 port B bit0
            // cb_keyOn
        }

        private void cb_interlock_en_CheckedChanged(object sender, EventArgs e)
        {
            // MCP23017 0x21 port A bit3
            // cb_interlock_en

        }
    }
}
