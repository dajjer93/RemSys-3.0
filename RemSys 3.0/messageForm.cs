using System;
using System.Drawing;
using System.Windows.Forms;
using RemSys_3._0.Properties;

namespace RemSys_3._0
{
    public partial class messageForm : Form
    {
        private int time = 30;
        public messageForm()
        {
            InitializeComponent();
        }

        public messageForm(TCPServer tCPServer, TCPServer.NewMessageEventArgs newMessageEventArgs)
        {
            InitializeComponent();
            TCPServer = tCPServer;
            NewMessageEventArgs = newMessageEventArgs;

            labelFrom.Text = "From: " + NewMessageEventArgs.Alias;
            labelMessage.Text = "Message: " + NewMessageEventArgs.Data;
        }

        private TCPServer TCPServer { get; set; }
        private TCPServer.NewMessageEventArgs NewMessageEventArgs { get; set; }

        public void SetParam(TCPServer tCPServer, TCPServer.NewMessageEventArgs newMessageEventArgs)
        {
            TCPServer = tCPServer;
            NewMessageEventArgs = newMessageEventArgs;
        }

        private void messageForm_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        public string GetIPPort()
        {
            return NewMessageEventArgs.IPPort;
        }

        public string GetReply()
        {
            return textBoxReply.Text;
        }

        private void buttonReply_Click(object sender, EventArgs e)
        {
            if (textBoxReply.Text != string.Empty)
            {
                TCPServer.SendMessage(Settings.Default.alias,
                    textBoxReply.Text,
                    NewMessageEventArgs.IPPort,
                    NewMessageEventArgs.LocalKeyPass);
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void messageForm_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time != 0)
            {
                time--;
            }

            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
            }
        }

        private void textBoxReply_TextChanged(object sender, EventArgs e)
        {
            time = 30;
        }

        private void textBoxReply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                buttonReply.PerformClick();
            }
        }
    }
}