using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsEditor
{
    public partial class MainWindow : Form
    {
        public List<string> lines = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //       METHODS        //

        private void MainWindow_Load(object sender, EventArgs e)
        {
            prepareView();
        }

        void prepareView()
        {
            readLinesIntoFile();
            populateGrid();

            CountLabel.Text = "Host entries loaded: " + lines.Count.ToString();
        }

        void readLinesIntoFile()
        {
            Utils.FileHelper fh = new Utils.FileHelper();

            fh.loadLinesIntoList(); // load lines from hosts file into fh var

            lines = fh.lines; // pass var over here
        }

        void populateGrid()
        {
            HostsGrid.Columns.Add("ip", "IP Address");
            HostsGrid.Columns.Add("hosts", "Hostname(s)");

            foreach (string line in lines)
            {
                string[] entry = line.Split(new char[] { ' ', '	'}, 2);

                HostsGrid.Rows.Add(entry);
            }

            HostsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            HostsGrid.AutoResizeColumns();
        }

        void clearGrid()
        {
            HostsGrid.Rows.Clear();
            HostsGrid.Refresh();

            prepareView();
        }

        // INTERACTIVE CONTROLS //

        private void EditButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "c:\\windows\\system32\\drivers\\etc\\hosts");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {

        }

        private void CLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aerouk/HostsEditor");
        }

        // ################### //
    }
}
