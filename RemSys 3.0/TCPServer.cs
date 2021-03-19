using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;
using RemSys_3._0.Properties;
using WatsonTcp;
using System.DirectoryServices;
using System.Linq;
using System.Net.Sockets;
using uhttpsharp;
using uhttpsharp.Listeners;
using uhttpsharp.Handlers;
using uhttpsharp.RequestProviders;
using uhttpsharpdemo.Handlers;
using SimpleTCP;

namespace RemSys_3._0
{
    public class TCPServer
    {
        
        private WatsonTcpClient MessageClient;
        private HttpServer httpServer;
        IndexHandler indexHandler;
        public List<Message> Messages { get; set; }
        private readonly WatsonTcpServer Server;
        private string cryptRef = @" qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM`1234567890-=[]\;',./~!@#$%^&*()_+{}|:" + Convert.ToString('"') + "<>?";
        private string cryptRef1 = @"zxcvbnmasdfghjklqwertyuiopPOIUYTREWQLKJHGFDSAMNBVCXZ /.,';\][=-0987654321`{}|:" + Convert.ToString('"') + "<>?~!@#$%^&*()_+";
        private string cryptRef2 = @"asdfghjkl;'`1234567890-=qwertyuiop[]\zxcvbnm,./~!@#$%^& *()_+ASDFGHJKL:" + Convert.ToString('"') + "ZXCVBNM<>?QWERTYUIOP{}|";
        public TCPServer()
        {
            try
            {
                Messages = new List<Message>();
                Server = new WatsonTcpServer(Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString(), 4999);
                Server.Events.ClientConnected += Server_ConnectionEstablished;
                Server.Events.ClientDisconnected += Events_ClientDisconnected;
                Server.Events.MessageReceived += Events_MessageReceived;
                Server.Start();
                httpServer = new HttpServer(new HttpRequestProvider());
                httpServer.Use(new TcpListenerAdapter(new TcpListener(IPAddress.Any, 4998)));
                httpServer.Use((context, next) =>
                {
                    try
                    {

                        string shot = string.Empty;
                        if (context.Request.Method == HttpMethods.Get)
                        {
                            bool isCommand = false;
                            string c = string.Empty;
                            string a = string.Empty;
                            string k = string.Empty;
                            foreach (KeyValuePair<string, string> keyValuePair in context.Request.Headers)
                            {
                                if (keyValuePair.Key == "t" && keyValuePair.Value == "###")
                                {
                                    isCommand = true;
                                }
                                else if (keyValuePair.Key == "c")
                                {
                                    c = keyValuePair.Value;
                                }
                                else if (keyValuePair.Key == "a")
                                {
                                    a = keyValuePair.Value;
                                }
                                else if (keyValuePair.Key == "k")
                                {
                                    k = keyValuePair.Value;
                                }
                            }
                            if(isCommand)
                            {
                                string result = string.Empty;
                                string error = string.Empty;
                                c = SubDecrypt(c);
                                a = SubDecrypt(a);
                                k = SubDecrypt(k);
                                Data.OnlineCommands com = Data.InsertOnlineCommand(context.RemoteEndPoint, c, context.RemoteEndPoint.GetHashCode());
                                bool status = CommandReceived(c, a, k, ref result, ref error);
                                com.Status = status;
                                com.Error = error;
                                com.Result = result;
                                if(com != null)
                                {
                                    Data.UpdateOnlineCommand(com);
                                }

                            }
                        }
                        return next();
                    }
                    catch (Exception e)
                    {
                        return next();
                    }
                });
                httpServer.Use(new TimingHandler());
                httpServer.Use(new HttpRouter().With(string.Empty, new IndexHandler())
                                    .With("about", new AboutHandler()));
                httpServer.Use(new FileHandler());
                httpServer.Use(new ErrorHandler());

                httpServer.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Error starting local server.");
            }
        }
        public  string SubDecrypt(string plainText)
        {
            string result = string.Empty;
            foreach(char c in plainText)
            {
                result += cryptRef1[cryptRef2.IndexOf(c)];
            }
            plainText = result;
            result = string.Empty;
            foreach(char c in plainText)
            {
                result += cryptRef[cryptRef1.IndexOf(c)];
            }
            return result;
        }


        public mainForm mainForm { get; set; }
        public event EventHandler<NewMessageEventArgs> NewMessage;
        public event EventHandler<MessageSentEventArgs> MessageSent;

        public void SendMessage(string alias, string data, string ipport, string keypass)
        {
            var message = new Dictionary<object, object>();
            MessageClient = new WatsonTcpClient(ipport.Split(':')[0], 4999);
            MessageClient.Events.MessageReceived += Events_MessageReceived1;
            message.Add("alias", crypto.StringCipher.Encrypt(alias));
            message.Add("message", crypto.StringCipher.Encrypt(data));
            message.Add("keypass", crypto.StringCipher.Encrypt(keypass));
            message.Add("localkeypass", Settings.Default.keypass);
            MessageClient.Connect();
            if (MessageClient.Connected)
            {
                MessageClient.Send("message", message);
                Messages.Add(new Message("To: " + alias, data, ipport.Split(':')[0] + ":" + 4999));
            }
        }


        private void Events_MessageReceived1(object sender, MessageReceivedEventArgs e)
        {
        }

        private void Events_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            if (Encoding.UTF8.GetString(e.Data) == "message")
            {
                if (crypto.StringCipher.Decrypt(e.Metadata["keypass"].ToString()) ==
                    crypto.StringCipher.Decrypt(Settings.Default.keypass))
                {
                    var eventHandler = NewMessage;
                    if (eventHandler != null)
                    {
                        var newMessageEventArgs = new NewMessageEventArgs(e.Metadata, e.IpPort);
                        eventHandler(this, newMessageEventArgs);
                        Messages.Add(new Message("From: " +
                                                 crypto.StringCipher.Decrypt(e.Metadata["alias"].ToString()),
                            crypto.StringCipher.Decrypt(e.Metadata["message"].ToString()), e.IpPort));
                        var backgroundWorker = new BackgroundWorker();
                        backgroundWorker.WorkerReportsProgress = true;
                        backgroundWorker.DoWork += BackgroundWorker_DoWork;
                        backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
                        backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
                        backgroundWorker.RunWorkerAsync(newMessageEventArgs);
                    }
                }
            }
            else
            {
                string result = string.Empty;
                string error = string.Empty;
                var status = CommandReceived(e.Metadata,ref result,ref error);
                if (status)
                {
                    if(result != string.Empty)
                    {
                        var keyValues = new Dictionary<object, object>();
                        keyValues.Add("result", crypto.StringCipher.Encrypt(result));
                        Server.Send(e.IpPort, "Success", keyValues);
                    }
                    else
                    {
                        Server.Send(e.IpPort, "Success");
                    }
                }
                else
                {
                    if(error != string.Empty)
                    {
                        var keyValues = new Dictionary<object, object>();
                        keyValues.Add("error", crypto.StringCipher.Encrypt(error));
                        Server.Send(e.IpPort, "Failed", keyValues);
                    }
                    else
                    {
                        Server.Send(e.IpPort, "Failed");
                    }
                }
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var eventHandler = MessageSent;
            if (eventHandler != null)
            {
                var sentMessage = (Dictionary<object, object>) e.UserState;
                eventHandler(this, new MessageSentEventArgs(
                    sentMessage["message"].ToString(),
                    sentMessage["ipport"].ToString()));
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ((BackgroundWorker) sender).Dispose();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var messageForm = new messageForm(this, (NewMessageEventArgs) e.Argument);
            if (messageForm.ShowDialog() != DialogResult.Cancel)
            {
                var SentMessage = new Dictionary<object, object>();
                SentMessage.Add("message", messageForm.GetReply());
                SentMessage.Add("ipport", messageForm.GetIPPort());
                ((BackgroundWorker) sender).ReportProgress(1, SentMessage);
                messageForm.Close();
            }
            else
            {
                messageForm.Dispose();
            }
        }

        private void Events_ClientDisconnected(object sender, DisconnectionEventArgs e)
        {
        }

        private void Server_ConnectionEstablished(object sender, ConnectionEventArgs args)
        {

        }

        private bool CommandReceived(Dictionary<object, object> metaData, ref string results, ref string errors)
        {
            if (crypto.StringCipher.Decrypt(metaData["keypass"].ToString()) ==
                crypto.StringCipher.Decrypt(Settings.Default.keypass))
            {
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.FileName = crypto.StringCipher.Decrypt(metaData["command"].ToString());
                if (metaData["arguments"] != null)
                    processStartInfo.Arguments = crypto.StringCipher.Decrypt(metaData["arguments"].ToString());
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                try
                {
                    using (var proc = new Process())
                    {
                        proc.StartInfo = processStartInfo;
                        proc.Start();
                        results = proc.StandardOutput.ReadToEnd();
                        errors = proc.StandardError.ReadToEnd();
                        proc.WaitForExit();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    errors = ex.Message;
                    return false;
                }
            }

            return false;
        }
        private bool CommandReceived(string com, string arg, string key, ref string results, ref string errors)
        {
            if (key ==
                crypto.StringCipher.Decrypt(Settings.Default.keypass))
            {
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.FileName = com;
                if (arg != null || arg != string.Empty)
                    processStartInfo.Arguments = arg;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                try
                {
                    using (var proc = new Process())
                    {
                        proc.StartInfo = processStartInfo;
                        proc.Start();
                        results = proc.StandardOutput.ReadToEnd();
                        errors = proc.StandardError.ReadToEnd();
                        proc.WaitForExit();
                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return false;
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

        public class NewMessageEventArgs : EventArgs
        {
            public NewMessageEventArgs(Dictionary<object, object> message, string ipport)
            {
                Data = crypto.StringCipher.Decrypt(message["message"].ToString());
                Alias = crypto.StringCipher.Decrypt(message["alias"].ToString());
                IPPort = ipport;
                Keypass = crypto.StringCipher.Decrypt(message["keypass"].ToString());
                LocalKeyPass = crypto.StringCipher.Decrypt(message["localkeypass"].ToString());
            }

            public string Data { get; set; }
            public string Alias { get; set; }
            public string IPPort { get; set; }
            public string Keypass { get; set; }
            public string LocalKeyPass { get; set; }
        }

        public class MessageSentEventArgs : EventArgs
        {
            public MessageSentEventArgs(string data, string ipport)
            {
                Data = data;
                IPPort = ipport;
            }

            public string Data { get; set; }
            public string IPPort { get; set; }
        }

        public class Message
        {

            public string Alias { get; set; }
            public string Data { get; set; }
            public DateTime Time { get; set; }
            public string IPPort { get; set; }

            public Message(string alias, string data, string ipport)
            {
                Alias = alias;
                Data = data;
                IPPort = ipport;
                Time = DateTime.Now;
            }
        }
        public class NetworkComputer
        {
            private string _domain;
            private string _name;
            private IPAddress[] _addresses = null;

            public string Domain { get { return _domain; } }
            public string Name { get { return _name; } }
            public IPAddress[] Addresses { get { return _addresses; } }

            private NetworkComputer(string domain, string name)
            {
                _domain = domain;
                _name = name;
                try { _addresses = Dns.GetHostAddresses(name); } catch { }
            }

            public static NetworkComputer[] GetLocalNetwork()
            {
                var list = new List<NetworkComputer>();
                using (var root = new DirectoryEntry("WinNT:"))
                {
                    foreach (var _ in root.Children.OfType<DirectoryEntry>())
                    {
                        switch (_.SchemaClassName)
                        {
                            case "Computer":
                                list.Add(new NetworkComputer("", _.Name));
                                break;
                            case "Domain":
                                list.AddRange(_.Children.OfType<DirectoryEntry>().Where(__ => (__.SchemaClassName == "Computer")).Select(__ => new NetworkComputer(_.Name, __.Name)));
                                break;
                        }
                    }
                }
                return list.OrderBy(_ => _.Domain).ThenBy(_ => _.Name).ToArray();
            }
        }

    }
}