using HostsEditor.Utils;
using System;
using System.Windows.Forms;

namespace HostsEditor
{
    /// <summary>
    /// Represents the dialog box for adding new host entries.
    /// </summary>
    public partial class NewHostWindow : Form
    {
        private bool ipValid, hostnameValid;
        private DataManager dataManager;

        /// <summary>
        /// Creates a new dialog using the associated data manager.
        /// </summary>
        /// <param name="dataManager">Data manager associated with the hosts file</param>
        public NewHostWindow(DataManager dataManager)
        {
            InitializeComponent();

            this.dataManager = dataManager;
            ipValid = false;
            hostnameValid = false;
        }

        /// <summary>
        /// Shows the validation result of the entered IP address and hostname.
        /// </summary>
        private void ShowValidationResult()
        {
            StringHelper.ValidationResult result = StringHelper.GenerateValidationResult(ipValid, hostnameValid);

            LabelStatus.ForeColor = result.color;
            LabelStatus.Text = result.output;
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
                    MessageBox.Show("The host entry could not be added. Please try again.");
            }
        }

        private void InputHostname_TextChanged(object sender, EventArgs e)
        {
            hostnameValid = StringHelper.ValidateHostname(InputHostname.Text);
            ShowValidationResult();
        }

        private void InputIPAddress_TextChanged(object sender, EventArgs e)
        {
            ipValid = StringHelper.ValidateIP(InputIPAddress.Text);
            ShowValidationResult();
        }
    }
}
