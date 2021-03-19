using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace RemSys_3._0
{
    internal class Data
    {
        private readonly string conString;

        public Data()
        {
            conString = Environment.CurrentDirectory + "/data.db";
            Commands = new List<Command>();
            AppLogs = new List<Logs>();
            GetCommands();
        }

        public List<Command> Commands { get; set; }
        public List<Logs> AppLogs { get; set; }
        public mainForm mainForm { get; set; }

        public void GetCommands()
        {
            try
            {
                Commands.Clear();
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Command>("commands");
                    Commands.AddRange(col.FindAll().ToArray());
                    foreach (var command in Commands) command.mainForm = mainForm;
                }
            }
            catch (Exception)
            {
            }
        }

        public Command InsertCommand(string title, string commandText, string args, string keypass, string ipaddress)
        {
            try
            {
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Command>("commands");
                    var command = new Command
                    {
                        Title = title,
                        CommandText = commandText,
                        Argument = args,
                        Keypass = keypass,
                        IPAddress = ipaddress
                    };
                    col.Insert(command);
                    Commands.Add(command);
                    return command;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void UpdateOnlineCommand(OnlineCommands onlineCommands)
        {
            try
            {
                using (var db = new LiteDatabase(Environment.CurrentDirectory + "/data.db"))
                {
                    var col = db.GetCollection<OnlineCommands>("onlinecommands");
                    col.Update(onlineCommands);
                }
            }
            catch (Exception)
            {
            }
        }

        public static OnlineCommands InsertOnlineCommand(System.Net.EndPoint endPoint, string com, int hashcode)
        {
            try
            {
                using (var db = new LiteDatabase(Environment.CurrentDirectory + "/data.db"))
                {
                    var col = db.GetCollection<OnlineCommands>("onlinecommands");
                    var command = new OnlineCommands
                    {
                        IP = endPoint.ToString().Split(':')[0],
                        Port = endPoint.ToString().Split(':')[1],
                        HashCode = hashcode,
                        Command = com,
                        Result = string.Empty,
                        Error = string.Empty,
                        Status = false
                    };
                    col.Insert(command);
                    return command;
                }
            }
            catch (Exception ex) {
                return null;
            }
        }
        public static OnlineCommands GetOnlineCommand(System.Net.EndPoint endPoint, string com, int hashcode)
        {
            try
            {
                OnlineCommands commands = null;
                using (var db = new LiteDatabase(Environment.CurrentDirectory + "/data.db"))
                {
                    var col = db.GetCollection<OnlineCommands>("onlinecommands");
                    var coms = col.FindAll().AsQueryable()
                        .Where(x => x.IP == endPoint.ToString().Split(':')[0] && 
                        x.Port == endPoint.ToString().Split(':')[1] && 
                        x.HashCode == hashcode &&
                        x.Command == com)
                        .Select(x => x).ToList();
                    if (coms.Count() > 0)
                    {
                        commands = coms[coms.Count() - 1];
                    }
                    return commands;
                }
            }
            catch (Exception) {
                return null;
            }
        }
        public static void ClearOnlineCommand()
        {
            try
            {
                using (var db = new LiteDatabase(Environment.CurrentDirectory + "/data.db"))
                {
                    var col = db.GetCollection<OnlineCommands>("onlinecommands");
                    col.DeleteAll();
                }
            }
            catch (Exception) { }
        }
        public bool UpdateCommand(Command command)
        {
            try
            {
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Command>("commands");
                    col.Update(command);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCommand(int id)
        {
            try
            {
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Command>("commands");
                    col.Delete(id);
                }

                GetCommands();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void InsertLog(string data)
        {
            try
            {
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Logs>("logs");
                    var log = new Logs
                    {
                        DateTime = DateTime.Now,
                        Data = data
                    };
                    col.Insert(log);
                    AppLogs.Add(log);
                }
            }
            catch (Exception)
            {
            }
        }

        public void GetLogs()
        {
            try
            {
                AppLogs.Clear();
                using (var db = new LiteDatabase(conString))
                {
                    var col = db.GetCollection<Logs>("logs");
                    AppLogs.AddRange(col.FindAll().ToArray());
                }
            }
            catch (Exception)
            {
            }
        }

        public class Logs
        {
            public int Id { get; set; }
            public DateTime DateTime { get; set; }
            public string Data { get; set; }
        }
        public class OnlineCommands
        {
            public int Id { get; set; }
            public int HashCode { get; set; }
            public string IP { get; set; }
            public string Port { get; set; }
            public string Command { get; set; }
            public bool Status { get; set; }
            public string Result { get; set; }
            public string Error { get; set; }
        }
    }
}