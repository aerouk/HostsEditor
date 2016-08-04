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
            this.EditButton = new System.Windows.Forms.Button();
            this.CLabel = new System.Windows.Forms.LinkLabel();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HostsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HostsGrid
            // 
            this.HostsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostsGrid.Location = new System.Drawing.Point(13, 13);
            this.HostsGrid.Name = "HostsGrid";
            this.HostsGrid.Size = new System.Drawing.Size(609, 374);
            this.HostsGrid.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Location = new System.Drawing.Point(90, 393);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(103, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit Hosts File";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CLabel
            // 
            this.CLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(18, 397);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(67, 13);
            this.CLabel.TabIndex = 2;
            this.CLabel.TabStop = true;
            this.CLabel.Text = "aerouk 2016";
            this.CLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CLabel_LinkClicked);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReloadButton.Location = new System.Drawing.Point(199, 393);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(103, 23);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Text = "Reload Hosts";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(309, 397);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 13);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Pending count...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 424);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.HostsGrid);
            this.MinimumSize = new System.Drawing.Size(650, 463);
            this.Name = "MainWindow";
            this.Text = "Hosts File Editor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HostsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HostsGrid;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.LinkLabel CLabel;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Label CountLabel;
    }
}

