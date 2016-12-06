using HostsEditor.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class MainWindow : Form
    {
        public List<HostRow> hosts { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            hosts = new List<HostRow>();
        }

        //       METHODS        //

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PrepareView();
        }

        private void PrepareView()
        {
            ReadLinesIntoFile();
            PopulateGrid();

            CountLabel.Text = "Host entries loaded: ";
        }

        private void ReadLinesIntoFile()
        {
            FileHelper fileHelper = new FileHelper();

            fileHelper.LoadLinesIntoList(); // load lines from hosts file into fh var
            hosts = fileHelper.hosts;
        }

        private void PopulateGrid()
        {
            foreach (HostRow hostRow in hosts)
            {
                string[] entry = {hostRow.ip, hostRow.host};

                HostsGrid.Rows.Add(entry);
            }

            HostsGrid.AutoResizeColumns();
        }

        private void ClearGrid()
        {
            HostsGrid.Rows.Clear();
            HostsGrid.Refresh();

            PrepareView();
        }

        private void BeginExit()
        {
            DialogResult exitDialogResult = MessageBox.Show("Are you sure you would like to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (exitDialogResult == DialogResult.Yes)
                Application.Exit();
        }

        // INTERACTIVE CONTROLS //

        private void EditButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "c:\\windows\\system32\\drivers\\etc\\hosts");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void CLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aerouk/HostsEditor");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginExit();
        }

        private void HostsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DataGridViewCell cell = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            Console.WriteLine(cell.Value.ToString());
        }

        // ################### //
    }
}
