using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
