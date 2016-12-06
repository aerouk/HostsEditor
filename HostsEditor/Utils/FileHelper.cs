using System.Collections.Generic;

namespace HostsEditor.Utils
{
    class FileHelper
    {
        public List<string> lines { get; set; }

        public FileHelper()
        {
            lines = new List<string>();
        }

        public void LoadLinesIntoList()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\windows\system32\drivers\etc\hosts");

            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();

                if (line.Length > 0 && line.ToCharArray()[0] != '#')
                {
                    lines.Add(line);
                }
            }

            file.Close();
        }
    }
}
