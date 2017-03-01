using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace HostsEditor
{
    /// <summary>
    /// Contains various utilities to keep the program up-to-date.
    /// </summary>
    class Updater
    {
        public string version { get; set; }
        public bool isCurrent { get; set; }
        private JObject json;

        /// <summary>
        /// Creates a new instance of the updater and sets up required fields.
        /// </summary>
        public Updater()
        {
            version = Application.ProductVersion;
            json = getLatestReleaseInfo();
            isCurrent = IsApplicationCurrent();

            if (!isCurrent)
                DisplayUpdateLink();
        }

        /// <summary>
        /// Retrieves the information pertaining to the most recent release of the program from the GitHub repo.
        /// </summary>
        /// <returns>JObject containins output from github releases page</returns>
        private JObject getLatestReleaseInfo()
        {
            WebClient client = new WebClient();

            client.Headers.Add("User-agent", $"HostsEditor {version} (https://github.com/aerouk/HostsEditor)");

            var json = client.DownloadString("http://api.github.com/repos/aerouk/HostsEditor/releases/latest");

            return JObject.Parse(json);
        }

        /// <summary>
        /// Checks whether the application is running the most recent version according to GitHub releases page.
        /// </summary>
        /// <returns>Whether the application is up-to-date</returns>
        private bool IsApplicationCurrent()
        {
            Version currentVer = new Version(version);
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
