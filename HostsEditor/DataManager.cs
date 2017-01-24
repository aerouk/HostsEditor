using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace HostsEditor.Utils
{
    /// <summary>
    /// A data manager containing methods to load/save entries to/from the hosts file.
    /// </summary>
    public class DataManager
    {
        public List<HostRow> Hosts { get; set; }
        public string path = Environment.SystemDirectory + @"\drivers\etc\hosts";

        public DataManager()
        {
            Hosts = new List<HostRow>();
        }

        /// <summary>
        /// Loads all hosts from the `hosts` file into the program.
        /// </summary>
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

        /// <summary>
        /// Adds a new host into the `hosts` file.
        /// </summary>
        /// <param name="hostRow">A HostRow object containing the IP address and Hostname to add to the file</param>
        /// <returns>Whether the new host could be added to the file or not.</returns>
        public bool AddHostToFile(HostRow hostRow)
        {
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
