using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace HostsEditor
{
    class Updater
    {
        public string version { get; set; }
        public bool isCurrent { get; set; }
        private JObject json;

        public Updater()
        {
            version = Application.ProductVersion;
            json = getLatestReleaseInfo();
            isCurrent = IsApplicationCurrent();

            if (!isCurrent)
                DisplayUpdateLink();
        }

        private JObject getLatestReleaseInfo()
        {
            WebClient client = new WebClient();

            client.Headers.Add("User-agent", $"HostsEditor {version} (https://github.com/aerouk/HostsEditor)");

            var json = client.DownloadString("http://api.github.com/repos/aerouk/HostsEditor/releases/latest");

            return JObject.Parse(json);
        }

        private bool IsApplicationCurrent()
        {
            Version currentVer = new Version(version);
            Version onlineVer = new Version(json["tag_name"].ToString());

            return currentVer.CompareTo(onlineVer) >= 0;
        }

        public void DisplayUpdateLink()
        {
            DialogResult dialogResult = MessageBox.Show("You are not using the most recent version. Visit the release page?", "Update Available", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                System.Diagnostics.Process.Start(json["html_url"].ToString());
        }
    }
}
