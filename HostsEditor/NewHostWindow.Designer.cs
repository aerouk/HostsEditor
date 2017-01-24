namespace HostsEditor
{
    partial class NewHostWindow
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
            this.components = new System.ComponentModel.Container();
            this.NewHostGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonAddHost = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.InputHostname = new System.Windows.Forms.TextBox();
            this.LabelHostname = new System.Windows.Forms.Label();
            this.InputIPAddress = new System.Windows.Forms.TextBox();
            this.LabelIPAddress = new System.Windows.Forms.Label();
            this.InputTimer = new System.Windows.Forms.Timer(this.components);
            this.NewHostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewHostGroupBox
            // 
            this.NewHostGroupBox.Controls.Add(this.ButtonAddHost);
            this.NewHostGroupBox.Controls.Add(this.LabelStatus);
            this.NewHostGroupBox.Controls.Add(this.InputHostname);
            this.NewHostGroupBox.Controls.Add(this.LabelHostname);
            this.NewHostGroupBox.Controls.Add(this.InputIPAddress);
            this.NewHostGroupBox.Controls.Add(this.LabelIPAddress);
            this.NewHostGroupBox.Location = new System.Drawing.Point(13, 13);
            this.NewHostGroupBox.Name = "NewHostGroupBox";
            this.NewHostGroupBox.Size = new System.Drawing.Size(306, 102);
            this.NewHostGroupBox.TabIndex = 0;
            this.NewHostGroupBox.TabStop = false;
            this.NewHostGroupBox.Text = "Add a New Host";
            // 
            // ButtonAddHost
            // 
            this.ButtonAddHost.Location = new System.Drawing.Point(70, 74);
            this.ButtonAddHost.Name = "ButtonAddHost";
            this.ButtonAddHost.Size = new System.Drawing.Size(99, 23);
            this.ButtonAddHost.TabIndex = 5;
            this.ButtonAddHost.Text = "Submit";
            this.ButtonAddHost.UseVisualStyleBackColor = true;
            this.ButtonAddHost.Click += new System.EventHandler(this.ButtonAddHost_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(207, 26);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(84, 13);
            this.LabelStatus.TabIndex = 4;
            this.LabelStatus.Text = "Waiting for input";
            // 
            // InputHostname
            // 
            this.InputHostname.Location = new System.Drawing.Point(70, 49);
            this.InputHostname.Name = "InputHostname";
            this.InputHostname.Size = new System.Drawing.Size(230, 20);
            this.InputHostname.TabIndex = 3;
            this.InputHostname.TextChanged += new System.EventHandler(this.InputHostname_TextChanged);
            // 
            // LabelHostname
            // 
            this.LabelHostname.AutoSize = true;
            this.LabelHostname.Location = new System.Drawing.Point(9, 52);
            this.LabelHostname.Name = "LabelHostname";
            this.LabelHostname.Size = new System.Drawing.Size(55, 13);
            this.LabelHostname.TabIndex = 2;
            this.LabelHostname.Text = "Hostname";
            // 
            // InputIPAddress
            // 
            this.InputIPAddress.Location = new System.Drawing.Point(70, 23);
            this.InputIPAddress.Name = "InputIPAddress";
            this.InputIPAddress.Size = new System.Drawing.Size(122, 20);
            this.InputIPAddress.TabIndex = 1;
            this.InputIPAddress.TextChanged += new System.EventHandler(this.InputIPAddress_TextChanged);
            // 
            // LabelIPAddress
            // 
            this.LabelIPAddress.AutoSize = true;
            this.LabelIPAddress.Location = new System.Drawing.Point(6, 26);
            this.LabelIPAddress.Name = "LabelIPAddress";
            this.LabelIPAddress.Size = new System.Drawing.Size(58, 13);
            this.LabelIPAddress.TabIndex = 0;
            this.LabelIPAddress.Text = "IP Address";
            // 
            // NewHostWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 127);
            this.Controls.Add(this.NewHostGroupBox);
            this.Name = "NewHostWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hosts File Editor";
            this.NewHostGroupBox.ResumeLayout(false);
            this.NewHostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewHostGroupBox;
        private System.Windows.Forms.Button ButtonAddHost;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.TextBox InputHostname;
        private System.Windows.Forms.Label LabelHostname;
        private System.Windows.Forms.TextBox InputIPAddress;
        private System.Windows.Forms.Label LabelIPAddress;
        private System.Windows.Forms.Timer InputTimer;
    }
}