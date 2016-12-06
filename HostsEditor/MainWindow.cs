using HostsEditor.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class MainWindow : Form
    {
        public List<string> lines { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            lines = new List<string>();
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

            CountLabel.Text = "Host entries loaded: " + lines.Count.ToString();
        }

        private void ReadLinesIntoFile()
        {
            FileHelper fileHelper = new FileHelper();

            fileHelper.LoadLinesIntoList(); // load lines from hosts file into fh var
            lines = fileHelper.lines; // pass var over here
        }

        private void PopulateGrid()
        {
            foreach (string line in lines)
            {
                string[] entry = line.Split(new char[] {' ', '\t'}, 2);

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

        // ################### //
    }
}
