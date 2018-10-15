namespace SpiI2cControlCsharp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Commands = new System.Windows.Forms.TabPage();
            this.btn_clr_spi_rx = new System.Windows.Forms.Button();
            this.btn_send_spi = new System.Windows.Forms.Button();
            this.lbl_spi_rx_data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_spiData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SpiAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_serial = new System.Windows.Forms.TabPage();
            this.cb_SerialPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ser_close = new System.Windows.Forms.Button();
            this.btn_Ser_open = new System.Windows.Forms.Button();
            this.btn_Ser_clear = new System.Windows.Forms.Button();
            this.tb_messages = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clr_i2c_rx = new System.Windows.Forms.Button();
            this.btn_i2c_read8raw = new System.Windows.Forms.Button();
            this.btn_i2c_read8 = new System.Windows.Forms.Button();
            this.btn_i2c_write8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_i2c_tx8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_i2c_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Tab_Commands.SuspendLayout();
            this.tab_serial.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Tab_Commands);
            this.tabControl1.Controls.Add(this.tab_serial);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Commands
            // 
            this.Tab_Commands.BackColor = System.Drawing.Color.Gainsboro;
            this.Tab_Commands.Controls.Add(this.btn_clr_spi_rx);
            this.Tab_Commands.Controls.Add(this.btn_send_spi);
            this.Tab_Commands.Controls.Add(this.lbl_spi_rx_data);
            this.Tab_Commands.Controls.Add(this.label5);
            this.Tab_Commands.Controls.Add(this.tb_spiData);
            this.Tab_Commands.Controls.Add(this.label4);
            this.Tab_Commands.Controls.Add(this.tb_SpiAddress);
            this.Tab_Commands.Controls.Add(this.label3);
            this.Tab_Commands.Location = new System.Drawing.Point(4, 27);
            this.Tab_Commands.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Commands.Name = "Tab_Commands";
            this.Tab_Commands.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Commands.Size = new System.Drawing.Size(633, 513);
            this.Tab_Commands.TabIndex = 0;
            this.Tab_Commands.Text = "Generic SPI";
            // 
            // btn_clr_spi_rx
            // 
            this.btn_clr_spi_rx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clr_spi_rx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clr_spi_rx.Location = new System.Drawing.Point(302, 84);
            this.btn_clr_spi_rx.Name = "btn_clr_spi_rx";
            this.btn_clr_spi_rx.Size = new System.Drawing.Size(173, 35);
            this.btn_clr_spi_rx.TabIndex = 31;
            this.btn_clr_spi_rx.Text = "Clear SPI RX Data";
            this.btn_clr_spi_rx.UseVisualStyleBackColor = false;
            this.btn_clr_spi_rx.Click += new System.EventHandler(this.btn_clr_spi_rx_Click);
            // 
            // btn_send_spi
            // 
            this.btn_send_spi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_send_spi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_send_spi.Location = new System.Drawing.Point(302, 44);
            this.btn_send_spi.Name = "btn_send_spi";
            this.btn_send_spi.Size = new System.Drawing.Size(102, 35);
            this.btn_send_spi.TabIndex = 9;
            this.btn_send_spi.Text = "Send SPI";
            this.btn_send_spi.UseVisualStyleBackColor = false;
            this.btn_send_spi.Click += new System.EventHandler(this.btn_send_spi_Click);
            // 
            // lbl_spi_rx_data
            // 
            this.lbl_spi_rx_data.AutoSize = true;
            this.lbl_spi_rx_data.Location = new System.Drawing.Point(160, 92);
            this.lbl_spi_rx_data.Name = "lbl_spi_rx_data";
            this.lbl_spi_rx_data.Size = new System.Drawing.Size(13, 18);
            this.lbl_spi_rx_data.TabIndex = 6;
            this.lbl_spi_rx_data.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "SPI RX Data (hex)";
            // 
            // tb_spiData
            // 
            this.tb_spiData.Location = new System.Drawing.Point(157, 55);
            this.tb_spiData.Name = "tb_spiData";
            this.tb_spiData.Size = new System.Drawing.Size(38, 24);
            this.tb_spiData.TabIndex = 4;
            this.tb_spiData.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "SPI TX Data (hex)";
            // 
            // tb_SpiAddress
            // 
            this.tb_SpiAddress.Location = new System.Drawing.Point(157, 16);
            this.tb_SpiAddress.Name = "tb_SpiAddress";
            this.tb_SpiAddress.Size = new System.Drawing.Size(27, 24);
            this.tb_SpiAddress.TabIndex = 2;
            this.tb_SpiAddress.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "SPI Address (hex)";
            // 
            // tab_serial
            // 
            this.tab_serial.BackColor = System.Drawing.Color.Gainsboro;
            this.tab_serial.Controls.Add(this.cb_SerialPorts);
            this.tab_serial.Controls.Add(this.label1);
            this.tab_serial.Controls.Add(this.btn_Ser_close);
            this.tab_serial.Controls.Add(this.btn_Ser_open);
            this.tab_serial.Controls.Add(this.btn_Ser_clear);
            this.tab_serial.Controls.Add(this.tb_messages);
            this.tab_serial.Location = new System.Drawing.Point(4, 27);
            this.tab_serial.Margin = new System.Windows.Forms.Padding(4);
            this.tab_serial.Name = "tab_serial";
            this.tab_serial.Padding = new System.Windows.Forms.Padding(4);
            this.tab_serial.Size = new System.Drawing.Size(633, 513);
            this.tab_serial.TabIndex = 1;
            this.tab_serial.Text = "Serial";
            // 
            // cb_SerialPorts
            // 
            this.cb_SerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SerialPorts.FormattingEnabled = true;
            this.cb_SerialPorts.Location = new System.Drawing.Point(383, 32);
            this.cb_SerialPorts.Name = "cb_SerialPorts";
            this.cb_SerialPorts.Size = new System.Drawing.Size(243, 26);
            this.cb_SerialPorts.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port 57600 8N1:";
            // 
            // btn_Ser_close
            // 
            this.btn_Ser_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_close.Location = new System.Drawing.Point(547, 64);
            this.btn_Ser_close.Name = "btn_Ser_close";
            this.btn_Ser_close.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_close.TabIndex = 3;
            this.btn_Ser_close.Text = "Close";
            this.btn_Ser_close.UseVisualStyleBackColor = true;
            this.btn_Ser_close.Click += new System.EventHandler(this.btn_Ser_close_Click);
            // 
            // btn_Ser_open
            // 
            this.btn_Ser_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_open.Location = new System.Drawing.Point(382, 64);
            this.btn_Ser_open.Name = "btn_Ser_open";
            this.btn_Ser_open.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_open.TabIndex = 2;
            this.btn_Ser_open.Text = "Open";
            this.btn_Ser_open.UseVisualStyleBackColor = true;
            this.btn_Ser_open.Click += new System.EventHandler(this.btn_Ser_open_Click);
            // 
            // btn_Ser_clear
            // 
            this.btn_Ser_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_clear.Location = new System.Drawing.Point(382, 478);
            this.btn_Ser_clear.Name = "btn_Ser_clear";
            this.btn_Ser_clear.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_clear.TabIndex = 1;
            this.btn_Ser_clear.Text = "Clear";
            this.btn_Ser_clear.UseVisualStyleBackColor = true;
            this.btn_Ser_clear.Click += new System.EventHandler(this.btn_Ser_clear_Click);
            // 
            // tb_messages
            // 
            this.tb_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_messages.Location = new System.Drawing.Point(7, 7);
            this.tb_messages.Multiline = true;
            this.tb_messages.Name = "tb_messages";
            this.tb_messages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_messages.Size = new System.Drawing.Size(369, 499);
            this.tb_messages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_clr_i2c_rx);
            this.tabPage1.Controls.Add(this.btn_i2c_read8raw);
            this.tabPage1.Controls.Add(this.btn_i2c_read8);
            this.tabPage1.Controls.Add(this.btn_i2c_write8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_i2c_tx8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tb_i2c_address);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 513);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Generic I2C";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 24);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 18);
            this.label19.TabIndex = 65;
            this.label19.Text = "I2C data bytes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(320, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 18);
            this.label18.TabIndex = 64;
            this.label18.Text = "w - write";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 18);
            this.label17.TabIndex = 63;
            this.label17.Text = "r - read register";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 18);
            this.label16.TabIndex = 62;
            this.label16.Text = "p -raw read";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(320, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "s - data byte size 0,1,2,3,4..";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 60;
            this.label14.Text = "DD - hex data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "RR - hex register";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 18);
            this.label12.TabIndex = 58;
            this.label12.Text = "AA - hex address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 57;
            this.label11.Text = "pAAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "rAARRS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "wAASDDDDDD";
            // 
            // btn_clr_i2c_rx
            // 
            this.btn_clr_i2c_rx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clr_i2c_rx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clr_i2c_rx.Location = new System.Drawing.Point(22, 440);
            this.btn_clr_i2c_rx.Name = "btn_clr_i2c_rx";
            this.btn_clr_i2c_rx.Size = new System.Drawing.Size(163, 35);
            this.btn_clr_i2c_rx.TabIndex = 54;
            this.btn_clr_i2c_rx.Text = "Clear I2C RX Data";
            this.btn_clr_i2c_rx.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_read8raw
            // 
            this.btn_i2c_read8raw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_read8raw.Location = new System.Drawing.Point(20, 333);
            this.btn_i2c_read8raw.Name = "btn_i2c_read8raw";
            this.btn_i2c_read8raw.Size = new System.Drawing.Size(165, 35);
            this.btn_i2c_read8raw.TabIndex = 53;
            this.btn_i2c_read8raw.Text = "I2c Read data, No reg";
            this.btn_i2c_read8raw.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_read8
            // 
            this.btn_i2c_read8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_read8.Location = new System.Drawing.Point(20, 294);
            this.btn_i2c_read8.Name = "btn_i2c_read8";
            this.btn_i2c_read8.Size = new System.Drawing.Size(163, 33);
            this.btn_i2c_read8.TabIndex = 52;
            this.btn_i2c_read8.Text = "I2c Read data";
            this.btn_i2c_read8.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_write8
            // 
            this.btn_i2c_write8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_write8.Location = new System.Drawing.Point(20, 255);
            this.btn_i2c_write8.Name = "btn_i2c_write8";
            this.btn_i2c_write8.Size = new System.Drawing.Size(163, 33);
            this.btn_i2c_write8.TabIndex = 51;
            this.btn_i2c_write8.Text = "I2c Write data";
            this.btn_i2c_write8.UseVisualStyleBackColor = false;
            this.btn_i2c_write8.Click += new System.EventHandler(this.btn_i2c_write8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "I2C RX Data (hex)";
            // 
            // tb_i2c_tx8
            // 
            this.tb_i2c_tx8.Location = new System.Drawing.Point(174, 142);
            this.tb_i2c_tx8.Name = "tb_i2c_tx8";
            this.tb_i2c_tx8.Size = new System.Drawing.Size(72, 24);
            this.tb_i2c_tx8.TabIndex = 48;
            this.tb_i2c_tx8.Text = "000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "I2C TX Data (hex)";
            // 
            // tb_i2c_address
            // 
            this.tb_i2c_address.Location = new System.Drawing.Point(174, 103);
            this.tb_i2c_address.Name = "tb_i2c_address";
            this.tb_i2c_address.Size = new System.Drawing.Size(30, 24);
            this.tb_i2c_address.TabIndex = 46;
            this.tb_i2c_address.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "I2C 7bit Address (hex)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 513);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "AMC7812 I2C";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(633, 513);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "MCP4725 DAC I2C";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(633, 513);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "MCP23017 I2C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 573);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SPI and I2C FPGA control";
            this.tabControl1.ResumeLayout(false);
            this.Tab_Commands.ResumeLayout(false);
            this.Tab_Commands.PerformLayout();
            this.tab_serial.ResumeLayout(false);
            this.tab_serial.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Commands;
        private System.Windows.Forms.TabPage tab_serial;
        private System.Windows.Forms.ComboBox cb_SerialPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ser_close;
        private System.Windows.Forms.Button btn_Ser_open;
        private System.Windows.Forms.Button btn_Ser_clear;
        private System.Windows.Forms.TextBox tb_messages;
        private System.Windows.Forms.Label lbl_spi_rx_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_spiData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SpiAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_send_spi;
        private System.Windows.Forms.Button btn_clr_spi_rx;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clr_i2c_rx;
        private System.Windows.Forms.Button btn_i2c_read8raw;
        private System.Windows.Forms.Button btn_i2c_read8;
        private System.Windows.Forms.Button btn_i2c_write8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_i2c_tx8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_i2c_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

