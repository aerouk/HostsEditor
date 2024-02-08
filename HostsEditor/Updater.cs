using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace HostsEditor
{
    /// <summary>
    /// Contains various utilities to keep the program up-to-date.
    /// </summary>
    class Updater
    {
        public string Version { get; set; }
        public bool IsCurrent { get; set; }
        private JObject json;

        /// <summary>
        /// Creates a new instance of the updater and sets up required fields.
        /// </summary>
        public Updater()
        {
            Version = Application.ProductVersion;
            json = GetLatestReleaseInfo();
            IsCurrent = IsApplicationCurrent();
        }

        /// <summary>
        /// Retrieves the information pertaining to the most recent release of the program from the GitHub repo.
        /// </summary>
        /// <returns>JObject containins output from github releases page</returns>
        private JObject GetLatestReleaseInfo()
        {
            LimitableWebClient client = new LimitableWebClient { Timeout = 5000 }; // WebClient with timeout of 5 seconds

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            client.Headers.Add("User-agent", $"HostsEditor {Version} (https://github.com/aerouk/HostsEditor)");

            var json = client.DownloadString("https://api.github.com/repos/aerouk/HostsEditor/releases/latest");

            return JObject.Parse(json);
        }

        /// <summary>
        /// Checks whether the application is running the most recent version according to GitHub releases page.
        /// </summary>
        /// <returns>Whether the application is up-to-date</returns>
        private bool IsApplicationCurrent()
        {
            Version currentVer = new Version(Version);
            Version onlineVer = new Version(json["tag_name"].ToString());

            return currentVer.CompareTo(onlineVer) >= 0;
        }

        /// <summary>
        /// Displays a dialog box asking the user if they want to visit the releases page.
        /// </summary>
        public void DisplayUpdateLink()
        {
            DialogResult dialogResult = MessageBox.Show("You are not using the most recent version. Visit the release page?", "Update Available", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                System.Diagnostics.Process.Start(json["html_url"].ToString());
        }
    }
}
