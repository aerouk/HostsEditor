namespace HostsEditor
{
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
