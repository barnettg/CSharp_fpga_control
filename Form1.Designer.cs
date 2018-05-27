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
            this.tab_serial = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Ser_clear = new System.Windows.Forms.Button();
            this.btn_Ser_open = new System.Windows.Forms.Button();
            this.btn_Ser_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SerialPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SpiAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_spiData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_spi_rx_data = new System.Windows.Forms.Label();
            this.btn_send_spi = new System.Windows.Forms.Button();
            this.btn_i2c_write8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_i2c_tx8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_i2c_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_i2c_write16 = new System.Windows.Forms.Button();
            this.btn_i2c_read8 = new System.Windows.Forms.Button();
            this.btn_i2c_read16 = new System.Windows.Forms.Button();
            this.btn_i2c_read8raw = new System.Windows.Forms.Button();
            this.btn_clr_spi_rx = new System.Windows.Forms.Button();
            this.btn_clr_i2c_rx = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_Commands.SuspendLayout();
            this.tab_serial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Tab_Commands);
            this.tabControl1.Controls.Add(this.tab_serial);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Commands
            // 
            this.Tab_Commands.BackColor = System.Drawing.Color.Gainsboro;
            this.Tab_Commands.Controls.Add(this.btn_clr_i2c_rx);
            this.Tab_Commands.Controls.Add(this.btn_clr_spi_rx);
            this.Tab_Commands.Controls.Add(this.btn_i2c_read8raw);
            this.Tab_Commands.Controls.Add(this.btn_i2c_read16);
            this.Tab_Commands.Controls.Add(this.btn_i2c_read8);
            this.Tab_Commands.Controls.Add(this.btn_i2c_write16);
            this.Tab_Commands.Controls.Add(this.btn_i2c_write8);
            this.Tab_Commands.Controls.Add(this.label7);
            this.Tab_Commands.Controls.Add(this.label8);
            this.Tab_Commands.Controls.Add(this.tb_i2c_tx8);
            this.Tab_Commands.Controls.Add(this.label9);
            this.Tab_Commands.Controls.Add(this.tb_i2c_address);
            this.Tab_Commands.Controls.Add(this.label10);
            this.Tab_Commands.Controls.Add(this.btn_send_spi);
            this.Tab_Commands.Controls.Add(this.lbl_spi_rx_data);
            this.Tab_Commands.Controls.Add(this.label5);
            this.Tab_Commands.Controls.Add(this.tb_spiData);
            this.Tab_Commands.Controls.Add(this.label4);
            this.Tab_Commands.Controls.Add(this.tb_SpiAddress);
            this.Tab_Commands.Controls.Add(this.label3);
            this.Tab_Commands.Location = new System.Drawing.Point(4, 27);
            this.Tab_Commands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tab_Commands.Name = "Tab_Commands";
            this.Tab_Commands.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tab_Commands.Size = new System.Drawing.Size(543, 513);
            this.Tab_Commands.TabIndex = 0;
            this.Tab_Commands.Text = "Generic Commands";
            // 
            // tab_serial
            // 
            this.tab_serial.BackColor = System.Drawing.Color.Gainsboro;
            this.tab_serial.Controls.Add(this.cb_SerialPorts);
            this.tab_serial.Controls.Add(this.label1);
            this.tab_serial.Controls.Add(this.btn_Ser_close);
            this.tab_serial.Controls.Add(this.btn_Ser_open);
            this.tab_serial.Controls.Add(this.btn_Ser_clear);
            this.tab_serial.Controls.Add(this.textBox1);
            this.tab_serial.Location = new System.Drawing.Point(4, 27);
            this.tab_serial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_serial.Name = "tab_serial";
            this.tab_serial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_serial.Size = new System.Drawing.Size(543, 513);
            this.tab_serial.TabIndex = 1;
            this.tab_serial.Text = "Serial";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(279, 499);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Ser_clear
            // 
            this.btn_Ser_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_clear.Location = new System.Drawing.Point(292, 478);
            this.btn_Ser_clear.Name = "btn_Ser_clear";
            this.btn_Ser_clear.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_clear.TabIndex = 1;
            this.btn_Ser_clear.Text = "Clear";
            this.btn_Ser_clear.UseVisualStyleBackColor = true;
            // 
            // btn_Ser_open
            // 
            this.btn_Ser_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_open.Location = new System.Drawing.Point(292, 64);
            this.btn_Ser_open.Name = "btn_Ser_open";
            this.btn_Ser_open.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_open.TabIndex = 2;
            this.btn_Ser_open.Text = "Open";
            this.btn_Ser_open.UseVisualStyleBackColor = true;
            // 
            // btn_Ser_close
            // 
            this.btn_Ser_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ser_close.Location = new System.Drawing.Point(457, 64);
            this.btn_Ser_close.Name = "btn_Ser_close";
            this.btn_Ser_close.Size = new System.Drawing.Size(79, 28);
            this.btn_Ser_close.TabIndex = 3;
            this.btn_Ser_close.Text = "Close";
            this.btn_Ser_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port 57600 8N1:";
            // 
            // cb_SerialPorts
            // 
            this.cb_SerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_SerialPorts.FormattingEnabled = true;
            this.cb_SerialPorts.Location = new System.Drawing.Point(293, 32);
            this.cb_SerialPorts.Name = "cb_SerialPorts";
            this.cb_SerialPorts.Size = new System.Drawing.Size(243, 26);
            this.cb_SerialPorts.TabIndex = 5;
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
            // tb_SpiAddress
            // 
            this.tb_SpiAddress.Location = new System.Drawing.Point(157, 16);
            this.tb_SpiAddress.Name = "tb_SpiAddress";
            this.tb_SpiAddress.Size = new System.Drawing.Size(27, 24);
            this.tb_SpiAddress.TabIndex = 2;
            this.tb_SpiAddress.Text = "00";
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
            // tb_spiData
            // 
            this.tb_spiData.Location = new System.Drawing.Point(157, 55);
            this.tb_spiData.Name = "tb_spiData";
            this.tb_spiData.Size = new System.Drawing.Size(38, 24);
            this.tb_spiData.TabIndex = 4;
            this.tb_spiData.Text = "0000";
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
            // lbl_spi_rx_data
            // 
            this.lbl_spi_rx_data.AutoSize = true;
            this.lbl_spi_rx_data.Location = new System.Drawing.Point(160, 92);
            this.lbl_spi_rx_data.Name = "lbl_spi_rx_data";
            this.lbl_spi_rx_data.Size = new System.Drawing.Size(13, 18);
            this.lbl_spi_rx_data.TabIndex = 6;
            this.lbl_spi_rx_data.Text = "-";
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
            // 
            // btn_i2c_write8
            // 
            this.btn_i2c_write8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_write8.Location = new System.Drawing.Point(28, 331);
            this.btn_i2c_write8.Name = "btn_i2c_write8";
            this.btn_i2c_write8.Size = new System.Drawing.Size(163, 33);
            this.btn_i2c_write8.TabIndex = 22;
            this.btn_i2c_write8.Text = "I2c Write 8bit data";
            this.btn_i2c_write8.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "I2C RX Data (hex)";
            // 
            // tb_i2c_tx8
            // 
            this.tb_i2c_tx8.Location = new System.Drawing.Point(183, 301);
            this.tb_i2c_tx8.Name = "tb_i2c_tx8";
            this.tb_i2c_tx8.Size = new System.Drawing.Size(43, 24);
            this.tb_i2c_tx8.TabIndex = 15;
            this.tb_i2c_tx8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "I2C TX Data (hex)";
            // 
            // tb_i2c_address
            // 
            this.tb_i2c_address.Location = new System.Drawing.Point(183, 262);
            this.tb_i2c_address.Name = "tb_i2c_address";
            this.tb_i2c_address.Size = new System.Drawing.Size(30, 24);
            this.tb_i2c_address.TabIndex = 13;
            this.tb_i2c_address.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "I2C 7bit Address (hex)";
            // 
            // btn_i2c_write16
            // 
            this.btn_i2c_write16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_write16.Location = new System.Drawing.Point(28, 370);
            this.btn_i2c_write16.Name = "btn_i2c_write16";
            this.btn_i2c_write16.Size = new System.Drawing.Size(163, 33);
            this.btn_i2c_write16.TabIndex = 27;
            this.btn_i2c_write16.Text = "I2c Write 16bit data";
            this.btn_i2c_write16.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_read8
            // 
            this.btn_i2c_read8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_read8.Location = new System.Drawing.Point(300, 331);
            this.btn_i2c_read8.Name = "btn_i2c_read8";
            this.btn_i2c_read8.Size = new System.Drawing.Size(163, 33);
            this.btn_i2c_read8.TabIndex = 28;
            this.btn_i2c_read8.Text = "I2c Read 8bit data";
            this.btn_i2c_read8.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_read16
            // 
            this.btn_i2c_read16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_read16.Location = new System.Drawing.Point(300, 370);
            this.btn_i2c_read16.Name = "btn_i2c_read16";
            this.btn_i2c_read16.Size = new System.Drawing.Size(165, 33);
            this.btn_i2c_read16.TabIndex = 29;
            this.btn_i2c_read16.Text = "I2c Read16bit data";
            this.btn_i2c_read16.UseVisualStyleBackColor = false;
            // 
            // btn_i2c_read8raw
            // 
            this.btn_i2c_read8raw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_i2c_read8raw.Location = new System.Drawing.Point(300, 409);
            this.btn_i2c_read8raw.Name = "btn_i2c_read8raw";
            this.btn_i2c_read8raw.Size = new System.Drawing.Size(165, 50);
            this.btn_i2c_read8raw.TabIndex = 30;
            this.btn_i2c_read8raw.Text = "I2c Read 8bit data, No Address";
            this.btn_i2c_read8raw.UseVisualStyleBackColor = false;
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
            // 
            // btn_clr_i2c_rx
            // 
            this.btn_clr_i2c_rx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clr_i2c_rx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clr_i2c_rx.Location = new System.Drawing.Point(302, 471);
            this.btn_clr_i2c_rx.Name = "btn_clr_i2c_rx";
            this.btn_clr_i2c_rx.Size = new System.Drawing.Size(163, 35);
            this.btn_clr_i2c_rx.TabIndex = 32;
            this.btn_clr_i2c_rx.Text = "Clear I2C RX Data";
            this.btn_clr_i2c_rx.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 573);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "SPI and I2C FPGA control";
            this.tabControl1.ResumeLayout(false);
            this.Tab_Commands.ResumeLayout(false);
            this.Tab_Commands.PerformLayout();
            this.tab_serial.ResumeLayout(false);
            this.tab_serial.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_spi_rx_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_spiData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_SpiAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_send_spi;
        private System.Windows.Forms.Button btn_i2c_read8raw;
        private System.Windows.Forms.Button btn_i2c_read16;
        private System.Windows.Forms.Button btn_i2c_read8;
        private System.Windows.Forms.Button btn_i2c_write16;
        private System.Windows.Forms.Button btn_i2c_write8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_i2c_tx8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_i2c_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clr_i2c_rx;
        private System.Windows.Forms.Button btn_clr_spi_rx;
    }
}

