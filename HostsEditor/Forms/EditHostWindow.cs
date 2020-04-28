using HostsEditor.Utils;
using System;
using System.Windows.Forms;

namespace HostsEditor
{
    /// <summary>
    /// Represents the dialog box for editing/deleting host entries.
    /// </summary>
    public partial class EditHostWindow : Form
    {
        private bool ipValid, hostnameValid;
        private DataManager dataManager;
        private HostRow hostRow;
        private int rowIndex;

        /// <summary>
        /// Creates a new dialog using the associated data manager.
        /// </summary>
        /// <param name="dataManager">Data manager associated with the hosts file</param>
        /// <param name="rowIndex">The row index where the host entry is from</param>
        /// <param name="hostRow">The host row data relative to the row index</param>
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

        /// <summary>
        /// Shows the validation result of the entered IP address and hostname.
        /// </summary>
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
                    Close();
                else
                    MessageBox.Show("The host entry could not be updated. Please correct the input and try again.");
            }
        }

        private void ButtonDeleteHost_Click(object sender, EventArgs e)
        {
            DialogResult exitDialogResult = MessageBox.Show("Are you sure you would like to delete this host?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exitDialogResult == DialogResult.Yes)
            {
                if (dataManager.DeleteHost(hostRow.FileRow))
                    Close();
                else
                    MessageBox.Show("The host entry could not be deleted. Please correct the input and try again.");
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
