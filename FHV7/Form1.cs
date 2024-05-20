using S7.Net;
using System.Drawing.Drawing2D;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

//zrobic w apce obsluge jak brakuje polaczenia zeby probowal laczyc sie na nowo

namespace FHV7
{
    public partial class Form1 : Form
    {
        private Plc plc;
        bool result;
        object FHV7_Run;
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(20000);
        }
        //closing windows - disconnect with PLC
        private void Form1_Closing(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d ok");
            }
        }

        //Connect to PLC - use only if you face with the problem to automatic connect to plc
        private void ConnectToPLCButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IPAddressTextBox.Text))
                {
                    throw new Exception("Invalid IP Address");
                }
                string IPAddressFromTextBox = IPAddressTextBox.Text;
                int SelectedCpuType = CPUTypeComboBox.SelectedIndex;
                CpuType plcType = 0;

                switch (SelectedCpuType)
                {
                    case 0:
                        plcType = CpuType.S7200;
                        break;
                    case 1:
                        plcType = CpuType.S7300;
                        break;
                    case 2:
                        plcType = CpuType.S7400;
                        break;
                    case 3:
                        plcType = CpuType.S71200;
                        break;
                    case 4:
                        plcType = CpuType.S71500;
                        break;
                    default:
                        plcType = CpuType.S71500;
                        break;
                }

                plc = new Plc(plcType, IPAddressFromTextBox, (short)RacknumericUpDown.Value, (short)SlotnumericUpDown.Value);
                plc.Open();

                if (plc.IsConnected)
                {
                    StatusPLCTextBox.Text = "ustanowiono po³¹czenie";
                    ReadDBButton.Enabled = true;
                    DisconnectPLCButton.Enabled = false;
                }
                else
                {
                    throw new Exception("B³¹d po³aczenia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d ok");
            }
        }

        //Disconnect with PLC - - use only if you face with the problem to automatic connect to plc
        private void DisconnectPLCButton_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
                if (!plc.IsConnected)
                {
                    StatusPLCTextBox.Text = "Zerwano po³¹czenie";
                }
                else
                {
                    DisconnectPLCButton.Enabled = false;
                    ConnectToPLCButton.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d ok");
            }
        }

        //Read DB Value from PLC - unused
        private void ReadDBButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc.IsConnected)
                {
                    FHV7_Run = plc.Read("DB1.DBW0");
                    DBValue.Text = $"Wartoœæ DB: {FHV7_Run}";
                    ushort result = (ushort)FHV7_Run;
                    if (result == 100)
                    {
                        Process.Start("D:\\Steam\\Steam.exe");
                        label6.Visible = true;
                        label7.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d ok");
            }
        }

        //Loading window - initializing value
        private void Form1_Load(object sender, EventArgs e)
        {

            IPAddressTextBox.Text = "192.168.2.1";
            CPUTypeComboBox.SelectedIndex = 4;
            RacknumericUpDown.Value = 0;
            SlotnumericUpDown.Value = 1;
            DBValue.Text = "Wartoœæ DB: ";
            ConnectToPLCButton.Enabled = false;
            ReadDBButton.Enabled = false;
            DisconnectPLCButton.Enabled = false;
            DBValue.Text = "Wartoœæ DB";
            label6.Visible = true;
            label7.Visible = false;

            try
            {
                plc = new Plc(CpuType.S71500, IPAddressTextBox.Text, (short)RacknumericUpDown.Value, (short)SlotnumericUpDown.Value);
                plc.Open();

                if (plc.IsConnected)
                {
                    StatusPLCTextBox.Text = "ustanowiono po³¹czenie";
                    ReadDBButton.Enabled = true;
                    DisconnectPLCButton.Enabled = false;

                    FHV7_Run = plc.Read("DB666.DBX0.0");
                    DBValue.Text = $"Wartoœæ DB: {FHV7_Run}";
                    result = (bool)FHV7_Run;
                    if (result == true)
                    {
                        Process.Start("D:\\Steam\\Steam.exe");
                        label6.Visible = true;
                        label7.Visible = true;
                    }
                    else
                    {
                        label6.Visible = true;
                        label7.Visible = false;
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    throw new Exception("B³¹d po³aczenia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "B³¹d po³¹czenia");
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FHV7_Run = plc.Read("DB666.DBX0.0");
            DBValue.Text = $"Wartoœæ DB: {FHV7_Run}";
            result = (bool)FHV7_Run;
            if (result == true)
            {
                Process.Start("D:\\Steam\\Steam.exe");
                label6.Visible = true;
                label7.Visible = true;
                timer1.Enabled = false;
            }
        }
    }
}
