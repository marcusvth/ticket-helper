using System;
using System.Collections.Generic;
using System.IO;
using tickethelper.Service.ActiveDirectory;

namespace tickethelper.Service
{
    internal class Log
    {
        public static readonly List<string> General = new List<string>();

        private static readonly Dictionary<int, string> Tags = new Dictionary<int, string>
        {
            {1, "[---INFO---]"},
            {2, "[!!!WARN!!!]"},
            {3, "[***ERRO***]"}
        };

        public static void Add(string message, int level)
        {
            var time = DateTime.Now.ToShortTimeString();
            var tag = Tags[level];
            var log = $"{Environment.NewLine}{tag} − [{time}] −► {message}{Environment.NewLine}";
            General.Add(log);
            if (EntryManager.CurrentDomain.Equals(EntryManager.HeiwayDomain)) return;
            Directory.CreateDirectory($@"{Environment.CurrentDirectory}\Logs");
            File.AppendAllText($@"{Environment.CurrentDirectory}\Logs\{Environment.UserName}.log", log);
        }
    }
}