namespace HostsEditor
{
    public class HostRow
    {
        public int fileRow { get; set; }
        public string ip { get; set; }
        public string host { get; set; }

        public HostRow(int fileRow, string ip, string host)
        {
            this.fileRow = fileRow;
            this.ip = ip;
            this.host = host;
        }  

        public HostRow(int fileRow, string hostString)
        {
            var lineContent = hostString.Split(new char[] { ' ', '\t' }, 2);

            this.fileRow = fileRow;
            ip = lineContent[0];
            host = lineContent[1];
        }
    }
}
