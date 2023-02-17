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
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Configuration;

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

            string myValue = Glitz_PoE.Properties.Settings.Default.DeviceID;
            if (myValue.Length > 2)
            {
                textBoxReadTagId.Text = myValue.ToString();
            }
            


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
            loadDefaultValue();
        }

        private void loadDefaultValue()
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
/*            string myValue = textBoxReadTagId.Text;
            Glitz_PoE.Properties.Settings.Default.DeviceID = myValue;
            Glitz_PoE.Properties.Settings.Default.Save();*/
            this.Close();
        }

        private void buttonWriteToDevice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button Writes to Device! Yet to to be implemented!");
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\nvadi\source\repos\Glitz-PoE\Glitz-PoE\Properties\UserDoc.pdf";
            System.Diagnostics.Process.Start(filename);
        }
/*        private void userManualToolStripMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
*//*            if(e.KeyCode == Keys.F1)
            {
                string filename = @"C:\Users\nvadi\source\repos\Glitz-PoE\Glitz-PoE\Properties\UserDoc.pdf";
                System.Diagnostics.Process.Start(filename);
            }*//*

        }*/

        private void loadDefaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDefaultValue();
        }
/*
        private void loadDefaultSettingsToolStripMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
*//*            if (e.Control && e.KeyCode == Keys.D)
            {
                loadDefaultValue();
            }*//*
        }*/

        private void writeToDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=bWXazVhlyxQ";
            try
            {
                Process.Start(url);
            }
            catch(Exception ex)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }

        }

/*        private void writeToDeviceTooStripMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.W)
            {

                string url = "https://www.youtube.com/watch?v=bWXazVhlyxQ";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }

            }
        }
*/
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
/*
        private void exitToolStripMenuItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.E)
            {
                this.Close();
            }
        }*/

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                string myValue = textBoxReadTagId.Text;
                Glitz_PoE.Properties.Settings.Default.DeviceID = myValue;
                Glitz_PoE.Properties.Settings.Default.Save();
                this.Close();
            }

            if (e.Control && e.KeyCode == Keys.W)
            {

                string url = "https://www.youtube.com/watch?v=bWXazVhlyxQ";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }

            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                loadDefaultValue();
            }

            if (e.KeyCode == Keys.F1)
            {
                string filename = @"C:\Users\nvadi\source\repos\Glitz-PoE\Glitz-PoE\Properties\UserDoc.pdf";
                System.Diagnostics.Process.Start(filename);
            }



        }
    }
}
