namespace HostsEditor
{
    /// <summary>
    /// Represents a hosts file entry, following the host line guidelines provided by Microsoft.
    /// </summary>
    public class HostRow
    {
        public int FileRow { get; set; }
        public string IP { get; set; }
        public string Host { get; set; }

        /// <summary>
        /// Host row representation, from a certain line in the file containing the IP address and hostname.
        /// </summary>
        /// <param name="fileRow">Row in the hosts file the entry is from</param>
        /// <param name="ip">IP address related to the host entry</param>
        /// <param name="host">Hostname related to the host entry</param>
        public HostRow(int fileRow, string ip, string host)
        {
            FileRow = fileRow;
            IP = ip;
            Host = host;
        }

        /// <summary>
        /// Host row representation, from a certain line in the file containing a string representation of the host entry.
        /// </summary>
        /// <param name="fileRow">Row in the hosts file the entry is from</param>
        /// <param name="hostString">Host string to be parsed by the program</param>
        public HostRow(int fileRow, string hostString)
        {
            var lineContent = hostString.Split(new char[] { ' ', '\t' }, 2);

            FileRow = fileRow;
            IP = lineContent[0];
            Host = lineContent[1];
        }
    }
}
