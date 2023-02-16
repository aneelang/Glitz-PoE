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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.comboBoxDefaultGateway4 = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultGateway3 = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultGateway2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultGateway1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetMask4 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetMask3 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetMask2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubnetMask1 = new System.Windows.Forms.ComboBox();
            this.comboBoxServerIP4 = new System.Windows.Forms.ComboBox();
            this.comboBoxServerIP3 = new System.Windows.Forms.ComboBox();
            this.comboBoxServerIP2 = new System.Windows.Forms.ComboBox();
            this.comboBoxServerIP1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceIP4 = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceIP3 = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceIP2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceIP1 = new System.Windows.Forms.ComboBox();
            this.labelDefaultGateway = new System.Windows.Forms.Label();
            this.labelSubnetMask = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelDeviceIP = new System.Windows.Forms.Label();
            this.buttonWriteToDevice = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLoadDefaultSettings = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.loadDefaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxReaderSettings.SuspendLayout();
            this.groupBoxPCSetting.SuspendLayout();
            this.groupBoxNetworkSettings.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            38.4D,
            76.8D,
            100D,
            200D,
            250D});
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
            this.groupBoxNetworkSettings.Controls.Add(this.textBoxPort);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDefaultGateway4);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDefaultGateway3);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDefaultGateway2);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDefaultGateway1);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxSubnetMask4);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxSubnetMask3);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxSubnetMask2);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxSubnetMask1);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxServerIP4);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxServerIP3);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxServerIP2);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxServerIP1);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDeviceIP4);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDeviceIP3);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDeviceIP2);
            this.groupBoxNetworkSettings.Controls.Add(this.comboBoxDeviceIP1);
            this.groupBoxNetworkSettings.Controls.Add(this.labelDefaultGateway);
            this.groupBoxNetworkSettings.Controls.Add(this.labelSubnetMask);
            this.groupBoxNetworkSettings.Controls.Add(this.labelPort);
            this.groupBoxNetworkSettings.Controls.Add(this.labelServerIP);
            this.groupBoxNetworkSettings.Controls.Add(this.labelDeviceIP);
            this.groupBoxNetworkSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNetworkSettings.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxNetworkSettings.Location = new System.Drawing.Point(390, 100);
            this.groupBoxNetworkSettings.Name = "groupBoxNetworkSettings";
            this.groupBoxNetworkSettings.Size = new System.Drawing.Size(384, 270);
            this.groupBoxNetworkSettings.TabIndex = 4;
            this.groupBoxNetworkSettings.TabStop = false;
            this.groupBoxNetworkSettings.Text = "Network Settings";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPort.Location = new System.Drawing.Point(122, 123);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(72, 23);
            this.textBoxPort.TabIndex = 24;
            // 
            // comboBoxDefaultGateway4
            // 
            this.comboBoxDefaultGateway4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultGateway4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDefaultGateway4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDefaultGateway4.FormattingEnabled = true;
            this.comboBoxDefaultGateway4.Location = new System.Drawing.Point(320, 221);
            this.comboBoxDefaultGateway4.Name = "comboBoxDefaultGateway4";
            this.comboBoxDefaultGateway4.Size = new System.Drawing.Size(48, 23);
            this.comboBoxDefaultGateway4.TabIndex = 23;
            // 
            // comboBoxDefaultGateway3
            // 
            this.comboBoxDefaultGateway3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultGateway3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDefaultGateway3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDefaultGateway3.FormattingEnabled = true;
            this.comboBoxDefaultGateway3.Location = new System.Drawing.Point(256, 221);
            this.comboBoxDefaultGateway3.Name = "comboBoxDefaultGateway3";
            this.comboBoxDefaultGateway3.Size = new System.Drawing.Size(54, 23);
            this.comboBoxDefaultGateway3.TabIndex = 22;
            // 
            // comboBoxDefaultGateway2
            // 
            this.comboBoxDefaultGateway2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultGateway2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDefaultGateway2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDefaultGateway2.FormattingEnabled = true;
            this.comboBoxDefaultGateway2.Location = new System.Drawing.Point(189, 221);
            this.comboBoxDefaultGateway2.Name = "comboBoxDefaultGateway2";
            this.comboBoxDefaultGateway2.Size = new System.Drawing.Size(48, 23);
            this.comboBoxDefaultGateway2.TabIndex = 21;
            // 
            // comboBoxDefaultGateway1
            // 
            this.comboBoxDefaultGateway1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultGateway1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDefaultGateway1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDefaultGateway1.FormattingEnabled = true;
            this.comboBoxDefaultGateway1.Location = new System.Drawing.Point(122, 221);
            this.comboBoxDefaultGateway1.Name = "comboBoxDefaultGateway1";
            this.comboBoxDefaultGateway1.Size = new System.Drawing.Size(50, 23);
            this.comboBoxDefaultGateway1.TabIndex = 20;
            // 
            // comboBoxSubnetMask4
            // 
            this.comboBoxSubnetMask4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubnetMask4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubnetMask4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxSubnetMask4.FormattingEnabled = true;
            this.comboBoxSubnetMask4.Location = new System.Drawing.Point(320, 176);
            this.comboBoxSubnetMask4.Name = "comboBoxSubnetMask4";
            this.comboBoxSubnetMask4.Size = new System.Drawing.Size(48, 23);
            this.comboBoxSubnetMask4.TabIndex = 19;
            // 
            // comboBoxSubnetMask3
            // 
            this.comboBoxSubnetMask3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubnetMask3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubnetMask3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxSubnetMask3.FormattingEnabled = true;
            this.comboBoxSubnetMask3.Location = new System.Drawing.Point(256, 176);
            this.comboBoxSubnetMask3.Name = "comboBoxSubnetMask3";
            this.comboBoxSubnetMask3.Size = new System.Drawing.Size(54, 23);
            this.comboBoxSubnetMask3.TabIndex = 18;
            // 
            // comboBoxSubnetMask2
            // 
            this.comboBoxSubnetMask2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubnetMask2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubnetMask2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxSubnetMask2.FormattingEnabled = true;
            this.comboBoxSubnetMask2.Location = new System.Drawing.Point(189, 176);
            this.comboBoxSubnetMask2.Name = "comboBoxSubnetMask2";
            this.comboBoxSubnetMask2.Size = new System.Drawing.Size(48, 23);
            this.comboBoxSubnetMask2.TabIndex = 17;
            // 
            // comboBoxSubnetMask1
            // 
            this.comboBoxSubnetMask1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubnetMask1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubnetMask1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxSubnetMask1.FormattingEnabled = true;
            this.comboBoxSubnetMask1.Location = new System.Drawing.Point(122, 176);
            this.comboBoxSubnetMask1.Name = "comboBoxSubnetMask1";
            this.comboBoxSubnetMask1.Size = new System.Drawing.Size(50, 23);
            this.comboBoxSubnetMask1.TabIndex = 16;
            // 
            // comboBoxServerIP4
            // 
            this.comboBoxServerIP4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerIP4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServerIP4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxServerIP4.FormattingEnabled = true;
            this.comboBoxServerIP4.Location = new System.Drawing.Point(320, 77);
            this.comboBoxServerIP4.Name = "comboBoxServerIP4";
            this.comboBoxServerIP4.Size = new System.Drawing.Size(48, 23);
            this.comboBoxServerIP4.TabIndex = 15;
            // 
            // comboBoxServerIP3
            // 
            this.comboBoxServerIP3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerIP3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServerIP3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxServerIP3.FormattingEnabled = true;
            this.comboBoxServerIP3.Location = new System.Drawing.Point(256, 77);
            this.comboBoxServerIP3.Name = "comboBoxServerIP3";
            this.comboBoxServerIP3.Size = new System.Drawing.Size(54, 23);
            this.comboBoxServerIP3.TabIndex = 14;
            // 
            // comboBoxServerIP2
            // 
            this.comboBoxServerIP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerIP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServerIP2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxServerIP2.FormattingEnabled = true;
            this.comboBoxServerIP2.Location = new System.Drawing.Point(189, 77);
            this.comboBoxServerIP2.Name = "comboBoxServerIP2";
            this.comboBoxServerIP2.Size = new System.Drawing.Size(48, 23);
            this.comboBoxServerIP2.TabIndex = 13;
            // 
            // comboBoxServerIP1
            // 
            this.comboBoxServerIP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerIP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServerIP1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxServerIP1.FormattingEnabled = true;
            this.comboBoxServerIP1.Location = new System.Drawing.Point(122, 77);
            this.comboBoxServerIP1.Name = "comboBoxServerIP1";
            this.comboBoxServerIP1.Size = new System.Drawing.Size(50, 23);
            this.comboBoxServerIP1.TabIndex = 12;
            // 
            // comboBoxDeviceIP4
            // 
            this.comboBoxDeviceIP4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceIP4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeviceIP4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDeviceIP4.FormattingEnabled = true;
            this.comboBoxDeviceIP4.Location = new System.Drawing.Point(320, 32);
            this.comboBoxDeviceIP4.Name = "comboBoxDeviceIP4";
            this.comboBoxDeviceIP4.Size = new System.Drawing.Size(48, 23);
            this.comboBoxDeviceIP4.TabIndex = 11;
            // 
            // comboBoxDeviceIP3
            // 
            this.comboBoxDeviceIP3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceIP3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeviceIP3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDeviceIP3.FormattingEnabled = true;
            this.comboBoxDeviceIP3.Location = new System.Drawing.Point(256, 32);
            this.comboBoxDeviceIP3.Name = "comboBoxDeviceIP3";
            this.comboBoxDeviceIP3.Size = new System.Drawing.Size(54, 23);
            this.comboBoxDeviceIP3.TabIndex = 10;
            // 
            // comboBoxDeviceIP2
            // 
            this.comboBoxDeviceIP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceIP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeviceIP2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDeviceIP2.FormattingEnabled = true;
            this.comboBoxDeviceIP2.Location = new System.Drawing.Point(189, 32);
            this.comboBoxDeviceIP2.Name = "comboBoxDeviceIP2";
            this.comboBoxDeviceIP2.Size = new System.Drawing.Size(48, 23);
            this.comboBoxDeviceIP2.TabIndex = 9;
            // 
            // comboBoxDeviceIP1
            // 
            this.comboBoxDeviceIP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceIP1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeviceIP1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDeviceIP1.FormattingEnabled = true;
            this.comboBoxDeviceIP1.Location = new System.Drawing.Point(122, 32);
            this.comboBoxDeviceIP1.Name = "comboBoxDeviceIP1";
            this.comboBoxDeviceIP1.Size = new System.Drawing.Size(50, 23);
            this.comboBoxDeviceIP1.TabIndex = 8;
            // 
            // labelDefaultGateway
            // 
            this.labelDefaultGateway.AutoSize = true;
            this.labelDefaultGateway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultGateway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDefaultGateway.Location = new System.Drawing.Point(22, 224);
            this.labelDefaultGateway.Name = "labelDefaultGateway";
            this.labelDefaultGateway.Size = new System.Drawing.Size(93, 15);
            this.labelDefaultGateway.TabIndex = 6;
            this.labelDefaultGateway.Text = "Default Gateway";
            // 
            // labelSubnetMask
            // 
            this.labelSubnetMask.AutoSize = true;
            this.labelSubnetMask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubnetMask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSubnetMask.Location = new System.Drawing.Point(22, 179);
            this.labelSubnetMask.Name = "labelSubnetMask";
            this.labelSubnetMask.Size = new System.Drawing.Size(75, 15);
            this.labelSubnetMask.TabIndex = 5;
            this.labelSubnetMask.Text = "Subnet Mask";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPort.Location = new System.Drawing.Point(22, 126);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 15);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelServerIP.Location = new System.Drawing.Point(22, 80);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(52, 15);
            this.labelServerIP.TabIndex = 3;
            this.labelServerIP.Text = "Server IP";
            // 
            // labelDeviceIP
            // 
            this.labelDeviceIP.AutoSize = true;
            this.labelDeviceIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDeviceIP.Location = new System.Drawing.Point(22, 32);
            this.labelDeviceIP.Name = "labelDeviceIP";
            this.labelDeviceIP.Size = new System.Drawing.Size(55, 15);
            this.labelDeviceIP.TabIndex = 2;
            this.labelDeviceIP.Text = "Device IP";
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
            this.buttonWriteToDevice.Click += new System.EventHandler(this.buttonWriteToDevice_Click);
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
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLoadDefaultSettings
            // 
            this.buttonLoadDefaultSettings.Location = new System.Drawing.Point(88, 389);
            this.buttonLoadDefaultSettings.Name = "buttonLoadDefaultSettings";
            this.buttonLoadDefaultSettings.Size = new System.Drawing.Size(80, 40);
            this.buttonLoadDefaultSettings.TabIndex = 9;
            this.buttonLoadDefaultSettings.Text = "Load Default Settings";
            this.buttonLoadDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonLoadDefaultSettings.Click += new System.EventHandler(this.buttonLoadDefaultSettings_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultSettingsToolStripMenuItem,
            this.writeToDeviceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(41, 22);
            this.toolStripSplitButton1.Text = "File";
            // 
            // loadDefaultSettingsToolStripMenuItem
            // 
            this.loadDefaultSettingsToolStripMenuItem.Name = "loadDefaultSettingsToolStripMenuItem";
            this.loadDefaultSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.loadDefaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.loadDefaultSettingsToolStripMenuItem.Text = "Load Default Settings";
            this.loadDefaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultSettingsToolStripMenuItem_Click);
            // 
            // writeToDeviceToolStripMenuItem
            // 
            this.writeToDeviceToolStripMenuItem.Name = "writeToDeviceToolStripMenuItem";
            this.writeToDeviceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToDeviceToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.writeToDeviceToolStripMenuItem.Text = "Write to Device";
            this.writeToDeviceToolStripMenuItem.Click += new System.EventHandler(this.writeToDeviceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripSplitButton2.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonLoadDefaultSettings);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteToDevice);
            this.Controls.Add(this.groupBoxNetworkSettings);
            this.Controls.Add(this.groupBoxPCSetting);
            this.Controls.Add(this.groupBoxReaderSettings);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelAppTitle);
            this.Name = "Form1";
            this.Text = "Glitz PoE Transmitter - Device Configuration Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loadDefaultSettingsToolStripMenuItem_KeyDown);
            this.groupBoxReaderSettings.ResumeLayout(false);
            this.groupBoxReaderSettings.PerformLayout();
            this.groupBoxPCSetting.ResumeLayout(false);
            this.groupBoxPCSetting.PerformLayout();
            this.groupBoxNetworkSettings.ResumeLayout(false);
            this.groupBoxNetworkSettings.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ComboBox comboBoxDefaultGateway4;
        private System.Windows.Forms.ComboBox comboBoxDefaultGateway3;
        private System.Windows.Forms.ComboBox comboBoxDefaultGateway2;
        private System.Windows.Forms.ComboBox comboBoxDefaultGateway1;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask4;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask3;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask2;
        private System.Windows.Forms.ComboBox comboBoxSubnetMask1;
        private System.Windows.Forms.ComboBox comboBoxServerIP4;
        private System.Windows.Forms.ComboBox comboBoxServerIP3;
        private System.Windows.Forms.ComboBox comboBoxServerIP2;
        private System.Windows.Forms.ComboBox comboBoxServerIP1;
        private System.Windows.Forms.ComboBox comboBoxDeviceIP4;
        private System.Windows.Forms.ComboBox comboBoxDeviceIP3;
        private System.Windows.Forms.ComboBox comboBoxDeviceIP2;
        private System.Windows.Forms.ComboBox comboBoxDeviceIP1;
        private System.Windows.Forms.Label labelDefaultGateway;
        private System.Windows.Forms.Label labelSubnetMask;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelDeviceIP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

