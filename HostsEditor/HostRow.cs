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

        public HostRow(int fileRow, string ip, string host)
        {
            FileRow = fileRow;
            IP = ip;
            Host = host;
        }

        public HostRow(int fileRow, string hostString)
        {
            var lineContent = hostString.Split(new char[] { ' ', '\t' }, 2);

            FileRow = fileRow;
            IP = lineContent[0];
            Host = lineContent[1];
        }
    }
}
