namespace HostsEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HostsGrid = new System.Windows.Forms.DataGridView();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewHostButton = new System.Windows.Forms.Button();
            this.addHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HostCount = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HostsGrid)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostsGrid
            // 
            this.HostsGrid.AllowUserToAddRows = false;
            this.HostsGrid.AllowUserToDeleteRows = false;
            this.HostsGrid.AllowUserToResizeColumns = false;
            this.HostsGrid.AllowUserToResizeRows = false;
            this.HostsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ip,
            this.host});
            this.HostsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HostsGrid.Location = new System.Drawing.Point(13, 27);
            this.HostsGrid.MultiSelect = false;
            this.HostsGrid.Name = "HostsGrid";
            this.HostsGrid.RowHeadersVisible = false;
            this.HostsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HostsGrid.Size = new System.Drawing.Size(609, 360);
            this.HostsGrid.TabIndex = 0;
            this.HostsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HostsGrid_CellDoubleClick);
            // 
            // ip
            // 
            this.ip.HeaderText = "IP Address";
            this.ip.Name = "ip";
            // 
            // host
            // 
            this.host.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.host.HeaderText = "Hostname";
            this.host.Name = "host";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Location = new System.Drawing.Point(122, 393);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Hosts File";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReloadButton.Location = new System.Drawing.Point(519, 393);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(103, 23);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Text = "Refresh";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.HostCount});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(634, 24);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHostToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // NewHostButton
            // 
            this.NewHostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewHostButton.Location = new System.Drawing.Point(13, 393);
            this.NewHostButton.Name = "NewHostButton";
            this.NewHostButton.Size = new System.Drawing.Size(103, 23);
            this.NewHostButton.TabIndex = 1;
            this.NewHostButton.Text = "Add Host";
            this.NewHostButton.UseVisualStyleBackColor = true;
            this.NewHostButton.Click += new System.EventHandler(this.NewHostButton_Click);
            // 
            // addHostToolStripMenuItem
            // 
            this.addHostToolStripMenuItem.Name = "addHostToolStripMenuItem";
            this.addHostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addHostToolStripMenuItem.Text = "Add Host";
            this.addHostToolStripMenuItem.Click += new System.EventHandler(this.addHostToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // HostCount
            // 
            this.HostCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HostCount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.HostCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostCount.Enabled = false;
            this.HostCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HostCount.Margin = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.HostCount.Name = "HostCount";
            this.HostCount.ReadOnly = true;
            this.HostCount.Size = new System.Drawing.Size(100, 17);
            this.HostCount.Text = "Hosts Loaded:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 424);
            this.Controls.Add(this.NewHostButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.HostsGrid);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 463);
            this.Name = "MainWindow";
            this.Text = "Hosts File Editor";
            ((System.ComponentModel.ISupportInitialize)(this.HostsGrid)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HostsGrid;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.Button NewHostButton;
        private System.Windows.Forms.ToolStripMenuItem addHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox HostCount;
    }
}

