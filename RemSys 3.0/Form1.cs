using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using RemSys_3._0.Properties;
using RunAtStartup;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace RemSys_3._0
{
    public partial class mainForm : MetroForm
    {
        private Command CurrentCommand;
        private Data Data;
        private StartupService StartupService;
        private TCPServer TCPServer;
        private int scanHostTime = 60;
        private bool tick = false;
        private List<string> HostList;
        
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            TCPServer = new TCPServer();
            TCPServer.NewMessage += TCPServer_NewMessage;
            TCPServer.MessageSent += TCPServer_MessageSent;
            Data = new Data();
            HostList = new List<string>();
            TCPServer.mainForm = this;
            Data.mainForm = this;
            if (Settings.Default.keypass != string.Empty)
                textBoxLocalKeypass.Text = crypto.StringCipher.Decrypt(Settings.Default.keypass);
            textBoxAlias.Text = Settings.Default.alias;
            checkBoxStartup.Checked = Settings.Default.runstartup;
            checkBoxHideStartup.Checked = Settings.Default.hidestartup;
            StartupService = new StartupService("Remsys 3.0");
            LoadData();
            LoadContextMenus();
            timer1.Start();
            comboBox1.Items.Clear();
            metroComboBox1.Items.Clear();
            foreach (TCPServer.NetworkComputer networkComputer in TCPServer.NetworkComputer.GetLocalNetwork())
            {
                comboBox1.Items.Add(networkComputer.Name);
                metroComboBox1.Items.Add(networkComputer.Name);
            }

            TCPServer.NetworkComputer.GetLocalNetwork();
        }


        private void TCPServer_MessageSent(object sender, TCPServer.MessageSentEventArgs e)
        {
        }

        private void TCPServer_NewMessage(object sender, TCPServer.NewMessageEventArgs e)
        {
            
        }

        private void LoadData()
        {
            listBox1.Items.Clear();
            foreach (var command in Data.Commands) listBox1.Items.Add(command.Title);
            if (listBox1.Items.Count != 0) listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                CurrentCommand = Data.Commands[listBox1.SelectedIndex];
                textBoxTitle.Text = CurrentCommand.Title;
                textBoxCommand.Text = CurrentCommand.CommandText;
                textBoxArguments.Text = CurrentCommand.Argument;
                textBoxKeypass.Text = CurrentCommand.Keypass;
                textBoxIPAddress.Text = CurrentCommand.IPAddress;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CurrentCommand = null;
            textBoxTitle.Text = string.Empty;
            textBoxCommand.Text = string.Empty;
            textBoxArguments.Text = string.Empty;
            textBoxKeypass.Text = string.Empty;
            textBoxIPAddress.Text = string.Empty;
            textBoxTitle.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CurrentCommand != null)
            {
                if (Data.DeleteCommand(CurrentCommand.Id))
                {
                    LoadData();
                    LoadContextMenus();
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == string.Empty ||
                textBoxCommand.Text == string.Empty ||
                textBoxKeypass.Text == string.Empty ||
                textBoxIPAddress.Text == string.Empty)
            {
                MessageBox.Show(
                    "Argument textbox can be left blank, everything else must be filled before saving command.");
                return;
            }

            if (CurrentCommand != null)
            {
                if (Data.Commands.AsQueryable()
                        .Select(x => x.Title.ToLower()).ToList()
                        .Contains(textBoxTitle.Text.ToLower()) &&
                    CurrentCommand.Title != textBoxTitle.Text)
                {
                    MessageBox.Show("Title already in existing.");
                    return;
                }

                CurrentCommand.Title = textBoxTitle.Text;
                CurrentCommand.CommandText = textBoxCommand.Text;
                CurrentCommand.Argument = textBoxArguments.Text;
                CurrentCommand.Keypass = textBoxKeypass.Text;
                CurrentCommand.IPAddress = textBoxIPAddress.Text;

                if (!Data.UpdateCommand(CurrentCommand))
                {
                    LoadData();
                    LoadContextMenus();
                    MessageBox.Show("Update failed!");
                }
                else
                {
                    MessageBox.Show("Updated!");
                }
            }
            else
            {
                if (Data.Commands.AsQueryable()
                    .Select(x => x.Title.ToLower()).ToList()
                    .Contains(textBoxTitle.Text.ToLower()))
                {
                    MessageBox.Show("Title already in existing.");
                    return;
                }

                CurrentCommand = Data.InsertCommand(textBoxTitle.Text, textBoxCommand.Text, textBoxArguments.Text,
                    textBoxKeypass.Text, textBoxIPAddress.Text);
                if (CurrentCommand != null)
                {
                    LoadData();
                    LoadContextMenus();
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("Save failed!");
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (CurrentCommand != null) CurrentCommand.SendCommand();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.keypass = crypto.StringCipher.Encrypt(textBoxLocalKeypass.Text);
            Settings.Default.Save();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible)
                Hide();
            else
                Show();
        }

        private void checkBoxStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (StartupService != null)
            {
                if (checkBoxStartup.Checked)
                    StartupService.Set(Environment.CurrentDirectory + @"\RemSys 3.0.exe");
                else
                    StartupService.Delete();
                Settings.Default.runstartup = checkBoxStartup.Checked;
                Settings.Default.Save();
            }
        }

        private void checkBoxHideStartup_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.hidestartup = checkBoxHideStartup.Checked;
            Settings.Default.Save();
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.hidestartup) Hide();
        }

        private void LoadContextMenus()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items) item.Click -= Item_Click;
            contextMenuStrip1.Items.Clear();
            foreach (var command in Data.Commands) contextMenuStrip1.Items.Add(command.Title);
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items) item.Click += Item_Click; 
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Data.Commands[contextMenuStrip1.Items.IndexOf((ToolStripItem) sender)].SendCommand();
        }

        private void textBoxAlias_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.alias = textBoxAlias.Text;
            Settings.Default.Save();
        }

        private bool IsValidIP(string ip)
        {
            try
            {
                if (ip == null || ip.Length == 0) return false;

                var parts = ip.Split(new[] {"."}, StringSplitOptions.None);
                if (parts.Length != 4) return false;

                foreach (var s in parts)
                {
                    var i = int.Parse(s);
                    if (i < 0 || i > 255) return false;
                }

                if (ip.EndsWith(".")) return false;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxChatRemoteHost.Text != string.Empty && textBoxRemoteKeypass.Text != string.Empty
                                                           && textBoxMessage.Text != string.Empty)
                try
                {
                    if (IsValidIP(textBoxChatRemoteHost.Text) && textBoxChatRemoteHost.Text != "127.0.0.1")
                        TCPServer.SendMessage(
                            Settings.Default.alias,
                            textBoxMessage.Text,
                            textBoxChatRemoteHost.Text + ":" + 4999,
                            textBoxRemoteKeypass.Text);
                    else if (textBoxChatRemoteHost.Text.ToLower() == "localhost" ||
                             textBoxChatRemoteHost.Text == "127.0.0.1")
                    {
                        string ipAddress = string.Empty;
                        if (textBoxChatRemoteHost.Text.ToLower() == "localhost")
                        {
                            var ipHost = Dns.GetHostEntry(Dns.GetHostName());
                            foreach (IPAddress ips in ipHost.AddressList)
                            {
                                if (IsValidIP(ips.ToString()))
                                {
                                    ipAddress = ips.ToString();
                                    break;
                                }
                            }
                        }
                        else
                        {

                            ipAddress = "127.0.0.1";
                        }

                        if (ipAddress != string.Empty)
                        {
                            TCPServer.SendMessage(
                                Settings.Default.alias,
                                textBoxMessage.Text,
                                ipAddress+ ":" + 4999,
                                textBoxRemoteKeypass.Text);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }

                    else
                    {

                        string ipAddress = string.Empty;
                        var ipHost = Dns.GetHostEntry(textBoxChatRemoteHost.Text);
                        foreach (IPAddress ips in ipHost.AddressList)
                        {
                            if (IsValidIP(ips.ToString()))
                            {
                                ipAddress = ips.ToString();
                                break;
                            }
                        }
                        if (ipAddress != string.Empty)
                        {
                            TCPServer.SendMessage(
                                Settings.Default.alias,
                                textBoxMessage.Text,
                                ipAddress + ":" + 4999,
                                textBoxRemoteKeypass.Text);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to send message!");
                }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("FUCK");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                foreach (TCPServer.Message tcpServerMessage in TCPServer.Messages)
                {
                    dataGridView1.Rows.Add(tcpServerMessage.Alias, tcpServerMessage.Data, tcpServerMessage.Time,
                        tcpServerMessage.IPPort);
                }
            }
            else
            {
                for (int i = dataGridView1.Rows.Count; i <= TCPServer.Messages.Count - 1; i++)
                {
                    dataGridView1.Rows.Add(TCPServer.Messages[i].Alias, TCPServer.Messages[i].Data,
                        TCPServer.Messages[i].Time, TCPServer.Messages[i].IPPort);
                }
            }

            if (!tick)
            {
                tick = true;
            }
            else
            {
                tick = false;
                if (scanHostTime <= 0)
                {
                    scanHostTime = 60;
                    HostList.Clear();
                    backgroundWorker1.RunWorkerAsync();

                }
                else
                {
                    scanHostTime--;
                }
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxChatRemoteHost.Text = comboBox1.SelectedItem.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press yes to exit", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIPAddress.Text = metroComboBox1.SelectedItem.ToString();
            
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBoxIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {

            }
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentCommand != null &&
                listBox1.SelectedItems.Count == 1)
            {
                if (Data.DeleteCommand(CurrentCommand.Id))
                {
                    LoadData();
                    LoadContextMenus();
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
        }

        private void runSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (object listBox1SelectedItem in listBox1.SelectedItems)
            {
                Data.Commands[listBox1.Items.IndexOf(listBox1SelectedItem)].SendCommand();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            foreach (TCPServer.NetworkComputer networkComputer in TCPServer.NetworkComputer.GetLocalNetwork())
            {
                HostList.Add(networkComputer.Name);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            comboBox1.Items.Clear();
            metroComboBox1.Items.Clear();
            foreach (string name in HostList)
            {
                comboBox1.Items.Add(name);
                metroComboBox1.Items.Add(name);
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.ClearOnlineCommand();
        }
    }
}