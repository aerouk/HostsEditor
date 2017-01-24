using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace HostsEditor.Utils
{
    public class DataLoader
    {
        public List<HostRow> Hosts { get; set; }
        public string path = Environment.SystemDirectory + @"\drivers\etc\hosts";

        public DataLoader()
        {
            Hosts = new List<HostRow>();
        }

        public void LoadHostsFromFile()
        {
            var lines = File.ReadAllLines(path);

            Hosts.Clear();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = Regex.Replace(lines[i].Trim(), @"\s+", " ");

                if (line.Length > 0 && !line.StartsWith("#"))
                    Hosts.Add(new HostRow(i, line));
            }
        }

        public bool AddHostToFile(HostRow hostRow)
        {
            // should we validate host&ip here?
            try
            {
                File.AppendAllText(path, $"{hostRow.IP} {hostRow.Host}" + Environment.NewLine);
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
