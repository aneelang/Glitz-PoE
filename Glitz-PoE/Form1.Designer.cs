namespace Glitz_PoE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxReaderSettings = new System.Windows.Forms.GroupBox();
            this.labelReadMhz = new System.Windows.Forms.Label();
            this.labelReadKbps = new System.Windows.Forms.Label();
            this.labelReadDbm = new System.Windows.Forms.Label();
            this.labelReadPowerLevel = new System.Windows.Forms.Label();
            this.comboBoxReadPowerLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxReadChannel = new System.Windows.Forms.ComboBox();
            this.labelReadChannel = new System.Windows.Forms.Label();
            this.comboBoxReadRFBaudRead = new System.Windows.Forms.ComboBox();
            this.labelReadRFBaudRate = new System.Windows.Forms.Label();
            this.textBoxReadTagId = new System.Windows.Forms.TextBox();
            this.labelReadTagId = new System.Windows.Forms.Label();
            this.groupBoxPCSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.groupBoxNetworkSettings = new System.Windows.Forms.GroupBox();
            this.buttonWriteToDevice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLoadDefaultSettings = new System.Windows.Forms.Button();
            this.groupBoxReaderSettings.SuspendLayout();
            this.groupBoxPCSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelAppTitle.Location = new System.Drawing.Point(180, 30);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(520, 28);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "Glitz PoE Transmitter - Device Configuration Utility";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(596, 71);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(178, 20);
            this.textBoxTime.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxReaderSettings
            // 
            this.groupBoxReaderSettings.Controls.Add(this.labelReadMhz);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadKbps);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadDbm);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadPowerLevel);
            this.groupBoxReaderSettings.Controls.Add(this.comboBoxReadPowerLevel);
            this.groupBoxReaderSettings.Controls.Add(this.comboBoxReadChannel);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadChannel);
            this.groupBoxReaderSettings.Controls.Add(this.comboBoxReadRFBaudRead);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadRFBaudRate);
            this.groupBoxReaderSettings.Controls.Add(this.textBoxReadTagId);
            this.groupBoxReaderSettings.Controls.Add(this.labelReadTagId);
            this.groupBoxReaderSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReaderSettings.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxReaderSettings.Location = new System.Drawing.Point(12, 100);
            this.groupBoxReaderSettings.Name = "groupBoxReaderSettings";
            this.groupBoxReaderSettings.Size = new System.Drawing.Size(361, 194);
            this.groupBoxReaderSettings.TabIndex = 2;
            this.groupBoxReaderSettings.TabStop = false;
            this.groupBoxReaderSettings.Text = "Reader Settings";
            // 
            // labelReadMhz
            // 
            this.labelReadMhz.AutoSize = true;
            this.labelReadMhz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadMhz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadMhz.Location = new System.Drawing.Point(246, 126);
            this.labelReadMhz.Name = "labelReadMhz";
            this.labelReadMhz.Size = new System.Drawing.Size(32, 15);
            this.labelReadMhz.TabIndex = 24;
            this.labelReadMhz.Text = "MHz";
            this.labelReadMhz.Click += new System.EventHandler(this.labelReadMhz_Click);
            // 
            // labelReadKbps
            // 
            this.labelReadKbps.AutoSize = true;
            this.labelReadKbps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadKbps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadKbps.Location = new System.Drawing.Point(246, 88);
            this.labelReadKbps.Name = "labelReadKbps";
            this.labelReadKbps.Size = new System.Drawing.Size(32, 15);
            this.labelReadKbps.TabIndex = 23;
            this.labelReadKbps.Text = "kbps";
            this.labelReadKbps.Click += new System.EventHandler(this.labelReadKbps_Click);
            // 
            // labelReadDbm
            // 
            this.labelReadDbm.AutoSize = true;
            this.labelReadDbm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadDbm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadDbm.Location = new System.Drawing.Point(246, 162);
            this.labelReadDbm.Name = "labelReadDbm";
            this.labelReadDbm.Size = new System.Drawing.Size(32, 15);
            this.labelReadDbm.TabIndex = 22;
            this.labelReadDbm.Text = "dBm";
            // 
            // labelReadPowerLevel
            // 
            this.labelReadPowerLevel.AutoSize = true;
            this.labelReadPowerLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadPowerLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadPowerLevel.Location = new System.Drawing.Point(26, 162);
            this.labelReadPowerLevel.Name = "labelReadPowerLevel";
            this.labelReadPowerLevel.Size = new System.Drawing.Size(70, 15);
            this.labelReadPowerLevel.TabIndex = 21;
            this.labelReadPowerLevel.Text = "Power Level";
            // 
            // comboBoxReadPowerLevel
            // 
            this.comboBoxReadPowerLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadPowerLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadPowerLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxReadPowerLevel.FormattingEnabled = true;
            this.comboBoxReadPowerLevel.Items.AddRange(new object[] {
            -30,
            -20,
            -15,
            -10,
            -6,
            0,
            5,
            7,
            10,
            12});
            this.comboBoxReadPowerLevel.Location = new System.Drawing.Point(173, 159);
            this.comboBoxReadPowerLevel.Name = "comboBoxReadPowerLevel";
            this.comboBoxReadPowerLevel.Size = new System.Drawing.Size(64, 23);
            this.comboBoxReadPowerLevel.TabIndex = 20;
            // 
            // comboBoxReadChannel
            // 
            this.comboBoxReadChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadChannel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxReadChannel.FormattingEnabled = true;
            this.comboBoxReadChannel.Location = new System.Drawing.Point(173, 123);
            this.comboBoxReadChannel.Name = "comboBoxReadChannel";
            this.comboBoxReadChannel.Size = new System.Drawing.Size(64, 23);
            this.comboBoxReadChannel.TabIndex = 10;
            // 
            // labelReadChannel
            // 
            this.labelReadChannel.AutoSize = true;
            this.labelReadChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadChannel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadChannel.Location = new System.Drawing.Point(26, 126);
            this.labelReadChannel.Name = "labelReadChannel";
            this.labelReadChannel.Size = new System.Drawing.Size(51, 15);
            this.labelReadChannel.TabIndex = 9;
            this.labelReadChannel.Text = "Channel";
            // 
            // comboBoxReadRFBaudRead
            // 
            this.comboBoxReadRFBaudRead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadRFBaudRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadRFBaudRead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxReadRFBaudRead.FormattingEnabled = true;
            this.comboBoxReadRFBaudRead.Items.AddRange(new object[] {
            9.6D,
            38.4D,
            100});
            this.comboBoxReadRFBaudRead.Location = new System.Drawing.Point(173, 80);
            this.comboBoxReadRFBaudRead.Name = "comboBoxReadRFBaudRead";
            this.comboBoxReadRFBaudRead.Size = new System.Drawing.Size(64, 23);
            this.comboBoxReadRFBaudRead.TabIndex = 7;
            // 
            // labelReadRFBaudRate
            // 
            this.labelReadRFBaudRate.AutoSize = true;
            this.labelReadRFBaudRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadRFBaudRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadRFBaudRate.Location = new System.Drawing.Point(26, 83);
            this.labelReadRFBaudRate.Name = "labelReadRFBaudRate";
            this.labelReadRFBaudRate.Size = new System.Drawing.Size(76, 15);
            this.labelReadRFBaudRate.TabIndex = 6;
            this.labelReadRFBaudRate.Text = "RF Baud Rate";
            // 
            // textBoxReadTagId
            // 
            this.textBoxReadTagId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReadTagId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxReadTagId.Location = new System.Drawing.Point(173, 29);
            this.textBoxReadTagId.Name = "textBoxReadTagId";
            this.textBoxReadTagId.Size = new System.Drawing.Size(106, 23);
            this.textBoxReadTagId.TabIndex = 2;
            // 
            // labelReadTagId
            // 
            this.labelReadTagId.AutoSize = true;
            this.labelReadTagId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadTagId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReadTagId.Location = new System.Drawing.Point(26, 29);
            this.labelReadTagId.Name = "labelReadTagId";
            this.labelReadTagId.Size = new System.Drawing.Size(56, 15);
            this.labelReadTagId.TabIndex = 1;
            this.labelReadTagId.Text = "Device ID";
            // 
            // groupBoxPCSetting
            // 
            this.groupBoxPCSetting.Controls.Add(this.comboBoxSerialPort);
            this.groupBoxPCSetting.Controls.Add(this.labelSerialPort);
            this.groupBoxPCSetting.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxPCSetting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPCSetting.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxPCSetting.Location = new System.Drawing.Point(12, 310);
            this.groupBoxPCSetting.Name = "groupBoxPCSetting";
            this.groupBoxPCSetting.Size = new System.Drawing.Size(361, 60);
            this.groupBoxPCSetting.TabIndex = 3;
            this.groupBoxPCSetting.TabStop = false;
            this.groupBoxPCSetting.Text = "PC Setting";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(173, 27);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(106, 23);
            this.comboBoxSerialPort.TabIndex = 17;
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSerialPort.Location = new System.Drawing.Point(25, 26);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(81, 20);
            this.labelSerialPort.TabIndex = 16;
            this.labelSerialPort.Text = "Serial Port";
            // 
            // groupBoxNetworkSettings
            // 
            this.groupBoxNetworkSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNetworkSettings.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxNetworkSettings.Location = new System.Drawing.Point(390, 100);
            this.groupBoxNetworkSettings.Name = "groupBoxNetworkSettings";
            this.groupBoxNetworkSettings.Size = new System.Drawing.Size(384, 270);
            this.groupBoxNetworkSettings.TabIndex = 4;
            this.groupBoxNetworkSettings.TabStop = false;
            this.groupBoxNetworkSettings.Text = "Network Settings";
            // 
            // buttonWriteToDevice
            // 
            this.buttonWriteToDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteToDevice.Location = new System.Drawing.Point(400, 387);
            this.buttonWriteToDevice.Name = "buttonWriteToDevice";
            this.buttonWriteToDevice.Size = new System.Drawing.Size(99, 42);
            this.buttonWriteToDevice.TabIndex = 7;
            this.buttonWriteToDevice.Text = "Write To Device";
            this.buttonWriteToDevice.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(579, 387);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 42);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDefaultSettings
            // 
            this.buttonLoadDefaultSettings.Location = new System.Drawing.Point(88, 389);
            this.buttonLoadDefaultSettings.Name = "buttonLoadDefaultSettings";
            this.buttonLoadDefaultSettings.Size = new System.Drawing.Size(80, 40);
            this.buttonLoadDefaultSettings.TabIndex = 9;
            this.buttonLoadDefaultSettings.Text = "Load Default Settings";
            this.buttonLoadDefaultSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadDefaultSettings);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteToDevice);
            this.Controls.Add(this.groupBoxNetworkSettings);
            this.Controls.Add(this.groupBoxPCSetting);
            this.Controls.Add(this.groupBoxReaderSettings);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelAppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxReaderSettings.ResumeLayout(false);
            this.groupBoxReaderSettings.PerformLayout();
            this.groupBoxPCSetting.ResumeLayout(false);
            this.groupBoxPCSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxReaderSettings;
        private System.Windows.Forms.GroupBox groupBoxPCSetting;
        private System.Windows.Forms.GroupBox groupBoxNetworkSettings;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.Label labelReadMhz;
        private System.Windows.Forms.Label labelReadKbps;
        private System.Windows.Forms.Label labelReadDbm;
        private System.Windows.Forms.Label labelReadPowerLevel;
        private System.Windows.Forms.ComboBox comboBoxReadPowerLevel;
        private System.Windows.Forms.ComboBox comboBoxReadChannel;
        private System.Windows.Forms.Label labelReadChannel;
        private System.Windows.Forms.ComboBox comboBoxReadRFBaudRead;
        private System.Windows.Forms.Label labelReadRFBaudRate;
        private System.Windows.Forms.TextBox textBoxReadTagId;
        private System.Windows.Forms.Label labelReadTagId;
        private System.Windows.Forms.Button buttonWriteToDevice;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLoadDefaultSettings;
    }
}

