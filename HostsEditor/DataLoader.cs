using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace HostsEditor.Utils
{
    public class DataLoader
    {
        public List<HostRow> hosts { get; set; }
        public string path = Environment.SystemDirectory + @"\drivers\etc\hosts";

        public DataLoader()
        {
            hosts = new List<HostRow>();
        }

        public void LoadHostsFromFile()
        {
            var lines = File.ReadAllLines(path);

            hosts.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = Regex.Replace(lines[i].Trim(), @"\s+", " ");

                if (line.Length > 0 && !line.StartsWith("#"))
                    hosts.Add(new HostRow(i, line));
            }
        }

        public bool AddHostToFile(string ip, string host)
        {
            try
            {
                File.AppendAllText(path, $"{ip} {host}" + Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

            return true;
        }
    }
}
