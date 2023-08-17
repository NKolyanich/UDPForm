using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPForm
{
    public partial class Form1 : Form
    {
        UDPServer udpserver;
        bool getSettings_flag = false;
        public Form1()
        {
            InitializeComponent();
            udpserver = new UDPServer();
            buttonStart.Text = "Start";
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            udpserver.DestinationIPAdress = IPAddress.Parse(textBoxDestHost.Text);
            udpserver.DestinationPort = Convert.ToInt16(textBoxDestPort.Text);
            udpserver.SendHexString(textBox_SendString.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                buttonStart.Text = "Stop";

                udpserver.OnSent += TerminalTextChangeOnSent;
                udpserver.OnReceive += TerminalTextChangeOnReceive;
                udpserver.StartReceive(Convert.ToInt16(textBoxLoopback_port.Text));
                
            }else
            if (buttonStart.Text == "Stop")
            {
               buttonStart.Text = "Start";
               udpserver.StopReceive();
            }
        }

        delegate void SetSendTextCallback(string data);
        void SetSendTerminalTextChange(string data)
        {
            if (this.textBoxTerminal.InvokeRequired)
            {
                SetSendTextCallback dt = new SetSendTextCallback(SetSendTerminalTextChange);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBoxTerminal.Text += data+"\r\n";
            }
        }

        private void TerminalTextChangeOnSent()
        {
            SetSendTerminalTextChange(udpserver.QueryString);
        }

        delegate void SetReceiveTextCallback(string data);
        void SetReceiveTerminalTextChange(string data)
        {
            if (this.textBoxTerminal.InvokeRequired)
            {
                SetReceiveTextCallback dt = new SetReceiveTextCallback(SetReceiveTerminalTextChange);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBoxTerminal.Text += "--->"+data + "\r\n";
            }
        }

        private void TerminalTextChangeOnReceive()
        {
            SetReceiveTerminalTextChange(udpserver.AnswerString);
            if (getSettings_flag)
                ParseAnswerSettings(udpserver.AnswerArray);
        }

        private void textBoxTerminal_TextChanged(object sender, EventArgs e)
        {
            textBoxTerminal.SelectionStart = textBoxTerminal.Text.Length;
            textBoxTerminal.ScrollToCaret();
        }

        private void button_SUSettings_Get_Click(object sender, EventArgs e)
        {
            textBox_SUSettings_MAC.ReadOnly = true;
            textBox_SUSettings_IP.ReadOnly = true;
            textBox_SUSettings_SRCPort.ReadOnly = true;
            textBox_SUSettings_DSTPort.ReadOnly = true;
            textBox_SUSettings_Pswd.ReadOnly = true;
            textBox_SUSettings_Time.ReadOnly = true;
            button_SUSettings_Set.Enabled = false;
            getSettings_flag = true;
            progressBar1.Value = 0;
            GetSettings(0);  
        }

        private string GetValueInMsg(byte[] data)
        {
            string str = "";
            for (int i = 6; i < data.Length; i++)
            {
                str += String.Format("{0:X}", data[i]);
            }
            return str;
        }

        private void GetSettings(int param)
        {
            udpserver.DestinationIPAdress = IPAddress.Parse(textBoxDestHost.Text);
            udpserver.DestinationPort = Convert.ToInt16(textBoxDestPort.Text);
            switch(param)
            {
                 case 0:
                    {
                        udpserver.SendHexString("7A02B96B1BB1");
                        break;
                    }
                case 1:
                    {
                        udpserver.SendHexString("7A02B96B1BB2");
                        break;
                    }
                case 2:
                    {
                        udpserver.SendHexString("7A02B96B1BB3");
                        break;
                    }
                case 3:
                    {
                        udpserver.SendHexString("7A02B96B1BB4");
                        break;
                    }
                case 4:
                    {
                        udpserver.SendHexString("7A02B96B1BB5");
                        break;
                    }
                case 5:
                    {
                        udpserver.SendHexString("7A02B96B1BB6");
                        break;
                    }

            }
        }

        private void ParseAnswerSettings(byte[] data)
        {
            if (data[4] == 0x1B)
            {
                switch (data[5])
                {
                    case 0xB1:
                        {
                            SetMACTextbox(GetValueInMsg(data));
                            GetSettings(1);
                            break;
                        }
                    case 0xB2:
                        {
                            SetIPTextbox(GetValueInMsg(data));
                            GetSettings(2);
                            break;
                        }
                    case 0xB3:
                        {
                            SetDSTPortTextbox(GetValueInMsg(data));
                            GetSettings(3);
                            break;
                        }
                    case 0xB4:
                        {
                            SetSRCPortTextbox(GetValueInMsg(data));
                            GetSettings(4);
                            break;
                        }
                    case 0xB5:
                        {
                            SetPswdTextbox(GetValueInMsg(data));
                            GetSettings(5);
                            break;
                        }
                    case 0xB6:
                        {
                            SetTimeTextbox(GetValueInMsg(data));
                            getSettings_flag = false;
                            break;
                        }
                }
            }
        }


        //================================================================================

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                udpserver.OnSent += TerminalTextChangeOnSent;
                udpserver.OnReceive += TerminalTextChangeOnReceive;
                udpserver.StartReceive(Convert.ToInt16(textBoxLoopback_port.Text));
            }
            else
            {
                udpserver.StopReceive();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpserver.StopReceive();
        }
        //================================================================================
        delegate void SetMACTextboxCallback(string data);
        void SetMACTextbox(string data)
        {
            if (this.textBox_SUSettings_MAC.InvokeRequired)
            {
                SetMACTextboxCallback dt = new SetMACTextboxCallback(SetMACTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_MAC.BackColor = Color.Lime;
                this.textBox_SUSettings_MAC.Refresh();
                this.textBox_SUSettings_MAC.Text = data;
                textBox_SUSettings_MAC.ReadOnly = false;
                progressBar1.Value++;
                System.Threading.Thread.Sleep(40);
                this.textBox_SUSettings_MAC.BackColor = Color.White;
            }
        }

        delegate void SetIPTextboxCallback(string data);
        void SetIPTextbox(string data)
        {
            if (this.textBox_SUSettings_IP.InvokeRequired)
            {
                SetIPTextboxCallback dt = new SetIPTextboxCallback(SetIPTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_IP.BackColor = Color.Lime;
                this.textBox_SUSettings_IP.Refresh();
                this.textBox_SUSettings_IP.Text = data;
                this.textBox_SUSettings_IP.ReadOnly = false;
                this.progressBar1.Value++;
                System.Threading.Thread.Sleep(40);
                this.textBox_SUSettings_IP.BackColor = Color.White;
            }
        }

        delegate void SetDSTPortTextboxCallback(string data);
        void SetDSTPortTextbox(string data)
        {
            if (this.textBox_SUSettings_DSTPort.InvokeRequired)
            {
                SetDSTPortTextboxCallback dt = new SetDSTPortTextboxCallback(SetDSTPortTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_DSTPort.Text = data;
                textBox_SUSettings_SRCPort.ReadOnly = false;
                progressBar1.Value++;
            }
        }

        delegate void SetSRCPortTextboxCallback(string data);
        void SetSRCPortTextbox(string data)
        {
            if (this.textBox_SUSettings_SRCPort.InvokeRequired)
            {
                SetSRCPortTextboxCallback dt = new SetSRCPortTextboxCallback(SetSRCPortTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_SRCPort.Text = data;
                textBox_SUSettings_SRCPort.ReadOnly = false;
                progressBar1.Value++;
            }
        }

        delegate void SetPswdTextboxCallback(string data);
        void SetPswdTextbox(string data)
        {
            if (this.textBox_SUSettings_Pswd.InvokeRequired)
            {
                SetPswdTextboxCallback dt = new SetPswdTextboxCallback(SetPswdTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_Pswd.Text = data;
                textBox_SUSettings_Pswd.ReadOnly = false;
                progressBar1.Value++;
            }
        }

        delegate void SetTimeTextboxCallback(string data);
        void SetTimeTextbox(string data)
        {
            if (this.textBox_SUSettings_Time.InvokeRequired)
            {
                SetTimeTextboxCallback dt = new SetTimeTextboxCallback(SetTimeTextbox);
                this.Invoke(dt, new object[] { data });
            }
            else
            {
                this.textBox_SUSettings_Time.Text = data;
                textBox_SUSettings_Time.ReadOnly = false;
                progressBar1.Value++;
                button_SUSettings_Set.Enabled = true;
                progressBar1.Value = 0;
            }
        }
        //===============================================================================
    }
}
