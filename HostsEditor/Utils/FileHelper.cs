using System.Collections.Generic;

namespace HostsEditor.Utils
{
    class FileHelper
    {
        public List<HostRow> hosts { get; set; }

        public FileHelper()
        {
            hosts = new List<HostRow>();
        }

        public void LoadLinesIntoList()
        {
            string line;
            int index = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\windows\system32\drivers\etc\hosts");

            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();

                if (line.Length > 0 && line.ToCharArray()[0] != '#')
                {
                    string[] lineContent = line.Split(new char[] { ' ', '\t' }, 2);

                    hosts.Add(new HostRow(index, lineContent[0], lineContent[1]));
                }

                index++;
            }

            file.Close();
        }
    }
}
