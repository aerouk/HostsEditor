using HostsEditor.Utils;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class NewHostWindow : Form
    {
        private bool ipValid, hostnameValid;
        private DataManager dataManager;

        public NewHostWindow(DataManager dataManager)
        {
            InitializeComponent();

            this.dataManager = dataManager;
            ipValid = false;
            hostnameValid = false;
        }

        private void ShowValidationResult()
        {
            if (ipValid)
            {
                if (hostnameValid)
                {
                    LabelStatus.ForeColor = System.Drawing.Color.Green;
                    LabelStatus.Text = "Input valid";
                }
                else
                {
                    LabelStatus.ForeColor = System.Drawing.Color.Red;
                    LabelStatus.Text = "Invalid host";
                }
            }
            else
            {
                LabelStatus.ForeColor = System.Drawing.Color.Red;
                LabelStatus.Text = "Invalid IP";
            }
        }

        private void ButtonAddHost_Click(object sender, EventArgs e)
        {
            if (ipValid && hostnameValid)
            {
                HostRow hostRow = new HostRow(-1, InputIPAddress.Text, InputHostname.Text);

                if (dataManager.AddHostToFile(hostRow))
                {
                    MessageBox.Show("New host was added to the hosts file!");
                    Close();
                }
                else
                    MessageBox.Show("The host file could not be added. Please try again.");
            }
        }

        private void InputHostname_TextChanged(object sender, EventArgs e)
        {
            hostnameValid = Uri.CheckHostName(InputHostname.Text).ToString() == "Dns";
            ShowValidationResult();
        }

        private void InputIPAddress_TextChanged(object sender, EventArgs e)
        {
            ipValid = Uri.CheckHostName(InputIPAddress.Text).ToString() == "IPv4";
            ShowValidationResult();
        }
    }
}
