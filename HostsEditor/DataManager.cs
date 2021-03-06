﻿using System;
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

        /// <summary>
        /// Creates a new data manager and sets up the hosts list for data entry.
        /// </summary>
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

        /// <summary>
        /// Updates a host entry in the `hosts` file.
        /// </summary>
        /// <param name="hostRow">The HostRow to update</param>
        /// <returns>Whether the host was able to be updated or not.</returns>
        public bool UpdateHost(HostRow hostRow)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                lines[hostRow.FileRow] = $"{hostRow.IP} {hostRow.Host}" + Environment.NewLine;
                File.WriteAllLines(path, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

            return true;
        }

        /// <summary>
        /// Delete a host entry from a specific line in the `hosts` file.
        /// </summary>
        /// <param name="fileRow">Row to delete from the hosts file</param>
        /// <returns>Whether the host was removed from the file or not.</returns>
        public bool DeleteHost(int fileRow)
        {
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));

                lines.RemoveAt(fileRow);
                File.WriteAllLines(path, lines);
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
