using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostsEditor.Utils
{
    class FileHelper
    {
        public List<string> lines = new List<string>();
        public int counter = 0;

        public void loadLinesIntoList()
        {
            counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\windows\system32\drivers\etc\hosts");
            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();

                if (line.Length > 0 && line.ToCharArray()[0] != '#')
                {
                    lines.Add(line);
                    counter++;
                }
            }

            file.Close();
        }
    }
}
