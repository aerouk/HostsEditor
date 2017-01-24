using HostsEditor.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class MainWindow : Form
    {
        public List<HostRow> Hosts { get; set; }
        private DataLoader dataLoader;

        public MainWindow()
        {
            InitializeComponent();

            dataLoader = new DataLoader();

            PrepareView();
            PopulateGrid();
        }

        //       METHODS        //

        private void PrepareView()
        {
            dataLoader.LoadHostsFromFile();

            Hosts = dataLoader.Hosts;
            CountLabel.Text = "Host entries loaded: " + Hosts.Count.ToString();

            PopulateGrid();
        }

        private void PopulateGrid()
        {
            foreach (HostRow hostRow in Hosts)
            {
                string[] entry = {hostRow.IP, hostRow.Host};

                HostsGrid.Rows.Add(entry);
            }

            HostsGrid.AutoResizeColumns();
        }

        private void ReloadGrid()
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
            System.Diagnostics.Process.Start("notepad.exe", Environment.SystemDirectory + @"\drivers\etc\hosts");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void CLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aerouk/HostsEditor");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeginExit();
        }

        private void HostsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DataGridViewCell cell = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            Console.WriteLine(cell.Value.ToString() + " " + Hosts[cell.RowIndex].FileRow);
        }

        private void NewHostButton_Click(object sender, EventArgs e)
        {

        }

        // ################### //
    }
}
