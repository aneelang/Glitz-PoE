using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Glitz_PoE
{
    public partial class Form1 : Form
    {

        SerialPort _serialPort = null;
        bool bReadPort = false;
        bool bWritePort = false;
        int bType = 0;
        public Form1()
        {
            InitializeComponent();
            setAllValues();
            textBoxReadTagId.Text = "RD01";
            comboBoxReadChannel.SelectedIndex = 0;
            comboBoxReadPowerLevel.SelectedIndex = 9;
            comboBoxReadRFBaudRead.SelectedIndex = 2;

            
            string[] portnames = SerialPort.GetPortNames();
            bReadPort = false;
            bWritePort = false;
            foreach (string name in portnames)
            {
                comboBoxSerialPort.Items.Add(name);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void setAllValues()
        {
            int IP_MAXVAL = 255;
            for(int i = 0; i <= IP_MAXVAL; i++)
            {
                comboBoxDefaultGateway1.Items.Add(i);
                comboBoxDefaultGateway2.Items.Add(i);
                comboBoxDefaultGateway3.Items.Add(i);
                comboBoxDefaultGateway4.Items.Add(i);
                comboBoxDeviceIP1.Items.Add(i);
                comboBoxDeviceIP2.Items.Add(i);
                comboBoxDeviceIP3.Items.Add(i);
                comboBoxDeviceIP4.Items.Add(i);
                comboBoxServerIP1.Items.Add(i);
                comboBoxServerIP2.Items.Add(i);
                comboBoxServerIP3.Items.Add(i);
                comboBoxServerIP4.Items.Add(i);
                comboBoxSubnetMask1.Items.Add(i);
                comboBoxSubnetMask2.Items.Add(i);
                comboBoxSubnetMask3.Items.Add(i);
                comboBoxSubnetMask4.Items.Add(i);
            }
            for (double i = 915.1; i <= 919.9; i = i + 0.2)
            {
                comboBoxReadChannel.Items.Add(Math.Round(i, 2));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void buttonLoadDefaultSettings_Click(object sender, EventArgs e)
        {
            textBoxReadTagId.Text = "RD01";
            comboBoxReadRFBaudRead.SelectedIndex = 2; // This isn't the best practice, if we decide to add more values to RF Baud Rate. Currently  RF Baud Rate[0] 
            comboBoxReadPowerLevel.SelectedIndex = 9;
            comboBoxReadChannel.SelectedIndex = 0;
            //
            // Default values of Subnet Mask
            //
            comboBoxSubnetMask1.SelectedIndex = 122;
            comboBoxSubnetMask2.SelectedIndex = 165;
            comboBoxSubnetMask3.SelectedIndex = 82;
            comboBoxSubnetMask4.SelectedIndex = 90;
            //
            // Default values of Server IP
            //
            comboBoxServerIP1.SelectedIndex = 122;
            comboBoxServerIP2.SelectedIndex = 165;
            comboBoxServerIP3.SelectedIndex = 82;
            comboBoxServerIP4.SelectedIndex = 90;
            //
            // Default values of Device IP
            //
            comboBoxDeviceIP1.SelectedIndex = 122;
            comboBoxDeviceIP2.SelectedIndex = 165;
            comboBoxDeviceIP3.SelectedIndex = 82;
            comboBoxDeviceIP4.SelectedIndex = 90;
            //
            // Default values of Default Gateway
            //
            comboBoxDefaultGateway1.SelectedIndex = 122;
            comboBoxDefaultGateway2.SelectedIndex = 165;
            comboBoxDefaultGateway3.SelectedIndex = 82;
            comboBoxDefaultGateway4.SelectedIndex = 90;
            //
            // Default values of Port
            //
            textBoxPort.Text = "05001";
        }
    }
}
