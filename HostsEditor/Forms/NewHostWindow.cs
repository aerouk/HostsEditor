using HostsEditor.Utils;
using System;
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
            ipValid = StringHelper.ValidateIPv4(InputIPAddress.Text);
            ShowValidationResult();
        }
    }
}
