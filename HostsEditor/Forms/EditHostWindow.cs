using HostsEditor.Utils;
using System;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class EditHostWindow : Form
    {
        private bool ipValid, hostnameValid;
        private DataManager dataManager;
        private HostRow hostRow;
        private int rowIndex;

        public EditHostWindow(DataManager dataManager, int rowIndex, HostRow hostRow)
        {
            InitializeComponent();

            this.dataManager = dataManager;
            this.hostRow = hostRow;
            ipValid = false;
            hostnameValid = false;
            this.rowIndex = rowIndex;

            InputIPAddress.Text = hostRow.IP;
            InputHostname.Text = hostRow.Host;

            ShowValidationResult();
        }

        private void ShowValidationResult()
        {
            StringHelper.ValidationResult result = StringHelper.GenerateValidationResult(ipValid, hostnameValid);

            LabelStatus.ForeColor = result.color;
            LabelStatus.Text = result.output;
        }

        private void ButtonEditHost_Click(object sender, EventArgs e)
        {
            if (ipValid && hostnameValid)
            {
                HostRow newHostRow = new HostRow(hostRow.FileRow, InputIPAddress.Text, InputHostname.Text);

                if (dataManager.UpdateHost(newHostRow))
                {
                    MessageBox.Show("The host was successfully updated.");
                    Close();
                }
                else
                    MessageBox.Show("The host entry could not be updated. Please try again.");
            }
        }

        private void ButtonDeleteHost_Click(object sender, EventArgs e)
        {
            DialogResult exitDialogResult = MessageBox.Show("Are you sure you would like to delete this host?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exitDialogResult == DialogResult.Yes)
            {
                if (dataManager.DeleteHost(hostRow.FileRow))
                {
                    MessageBox.Show("The host was successfully deleted.");
                    Close();
                }
                else
                    MessageBox.Show("The host entry could not be deleted. Please try again.");
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
