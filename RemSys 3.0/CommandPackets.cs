using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WatsonTcp;

namespace RemSys_3._0
{
    public class Command
    {
        private WatsonTcpClient tcpClient;

        public Command()
        {
            Port = 4999;
            Title = string.Empty;
            CommandText = string.Empty;
            Argument = string.Empty;
            Keypass = string.Empty;
            IPAddress = string.Empty;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string CommandText { get; set; }
        public string Argument { get; set; }
        public string Keypass { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; }
        public mainForm mainForm { get; set; }

        public void SendCommand()
        {
            if (CommandText != string.Empty && Keypass != string.Empty && IPAddress != string.Empty)
                try
                {
                    if (IsValidIP(IPAddress) && IPAddress != "127.0.0.1")
                        tcpClient = new WatsonTcpClient(IPAddress, Port);
                    else if (IPAddress.ToLower() == "localhost" || IPAddress == "127.0.0.1")
                    {
                        string ipAddress = string.Empty;
                        if (IPAddress.ToLower() == "localhost")
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
                            tcpClient = new WatsonTcpClient(ipAddress,
                                Port);
                        }
                        else
                        {
                            throw  new Exception();
                        }
                    }
                    else
                    {
                        string ipAddress = string.Empty;
                        var ipHost = Dns.GetHostEntry(IPAddress);
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
                            tcpClient = new WatsonTcpClient(ipAddress,
                                Port);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    tcpClient.Events.ServerConnected += Con_ConnectionEstablished;
                    tcpClient.Events.ServerDisconnected += ClientConnectionContainer_ConnectionLost;
                    tcpClient.Events.MessageReceived += Events_MessageReceived;
                    var metaData = new Dictionary<object, object>();
                    metaData.Add("command", crypto.StringCipher.Encrypt(CommandText));
                    if (Argument == null)
                    {

                        metaData.Add("arguments", crypto.StringCipher.Encrypt(string.Empty));
                    }
                    else
                    {
                        metaData.Add("arguments", crypto.StringCipher.Encrypt(Argument));
                    }
                    metaData.Add("keypass", crypto.StringCipher.Encrypt(Keypass));
                    tcpClient.Connect();
                    if (tcpClient.Connected) tcpClient.Send("command", metaData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                MessageBox.Show("Cannot send an incomplete command.");
        }

        private void Events_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            CommandResponseReceived(e);
            if (tcpClient.Connected)
            {
                tcpClient.Disconnect();
                tcpClient.Dispose();
            }
        }

        private void ClientConnectionContainer_ConnectionLost(object sender, DisconnectionEventArgs eventArgs)
        {
        }

        private void Con_ConnectionEstablished(object sender, ConnectionEventArgs eventArgs)
        {
        }

        private void CommandResponseReceived(MessageReceivedEventArgs eventArgs)
        {
            if (Encoding.UTF8.GetString(eventArgs.Data) == "Success")
            {
                if (eventArgs.Metadata != null)
                {
                    MessageBox.Show(string.Format(@"Command Success!

Results: 
{0}", crypto.StringCipher.Decrypt(eventArgs.Metadata["result"].ToString())));
                }
                else
                {
                    MessageBox.Show("Command Success!");
                }
            }
            else
            {
                if(eventArgs.Metadata != null)
                {
                    MessageBox.Show(string.Format(@"Command Failed!

Results: 
{0}", crypto.StringCipher.Decrypt(eventArgs.Metadata["error"].ToString())));
                }
                else
                {
                    MessageBox.Show("Command Failed!");
                }
            }
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
    }
}