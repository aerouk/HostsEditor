using System;
using System.Collections.Generic;
using System.IO;

namespace HostsEditor.Utils
{
    class DataLoader
    {
        public List<HostRow> hosts { get; set; }

        public DataLoader()
        {
            hosts = new List<HostRow>();
        }

        public void LoadHostsFromFile()
        {
            var lines = File.ReadAllLines(Environment.SystemDirectory + @"\drivers\etc\hosts");

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();

                if (line.Length > 0 && !line.StartsWith("#"))
                    hosts.Add(new HostRow(i, line));
            }
        }
    }
}
