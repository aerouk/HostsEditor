namespace HostsEditor
{
    partial class EditHostWindow
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
            this.LabelIPAddress = new System.Windows.Forms.Label();
            this.EditHostGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonDeleteHost = new System.Windows.Forms.Button();
            this.ButtonEditHost = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.InputHostname = new System.Windows.Forms.TextBox();
            this.LabelHostname = new System.Windows.Forms.Label();
            this.InputIPAddress = new System.Windows.Forms.TextBox();
            this.InputTimer = new System.Windows.Forms.Timer(this.components);
            this.EditHostGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // EditHostGroupBox
            // 
            this.EditHostGroupBox.Controls.Add(this.ButtonDeleteHost);
            this.EditHostGroupBox.Controls.Add(this.ButtonEditHost);
            this.EditHostGroupBox.Controls.Add(this.LabelStatus);
            this.EditHostGroupBox.Controls.Add(this.InputHostname);
            this.EditHostGroupBox.Controls.Add(this.LabelHostname);
            this.EditHostGroupBox.Controls.Add(this.InputIPAddress);
            this.EditHostGroupBox.Controls.Add(this.LabelIPAddress);
            this.EditHostGroupBox.Location = new System.Drawing.Point(13, 13);
            this.EditHostGroupBox.Name = "EditHostGroupBox";
            this.EditHostGroupBox.Size = new System.Drawing.Size(306, 102);
            this.EditHostGroupBox.TabIndex = 1;
            this.EditHostGroupBox.TabStop = false;
            this.EditHostGroupBox.Text = "Edit a Host";
            // 
            // ButtonDeleteHost
            // 
            this.ButtonDeleteHost.Location = new System.Drawing.Point(175, 73);
            this.ButtonDeleteHost.Name = "ButtonDeleteHost";
            this.ButtonDeleteHost.Size = new System.Drawing.Size(99, 23);
            this.ButtonDeleteHost.TabIndex = 6;
            this.ButtonDeleteHost.Text = "Delete Host";
            this.ButtonDeleteHost.UseVisualStyleBackColor = true;
            this.ButtonDeleteHost.Click += new System.EventHandler(this.ButtonDeleteHost_Click);
            // 
            // ButtonEditHost
            // 
            this.ButtonEditHost.Location = new System.Drawing.Point(70, 74);
            this.ButtonEditHost.Name = "ButtonEditHost";
            this.ButtonEditHost.Size = new System.Drawing.Size(99, 23);
            this.ButtonEditHost.TabIndex = 5;
            this.ButtonEditHost.Text = "Submit";
            this.ButtonEditHost.UseVisualStyleBackColor = true;
            this.ButtonEditHost.Click += new System.EventHandler(this.ButtonEditHost_Click);
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
            // EditHostWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 127);
            this.Controls.Add(this.EditHostGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditHostWindow";
            this.Text = "Hosts File Editor";
            this.EditHostGroupBox.ResumeLayout(false);
            this.EditHostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelIPAddress;
        private System.Windows.Forms.GroupBox EditHostGroupBox;
        private System.Windows.Forms.Button ButtonEditHost;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.TextBox InputHostname;
        private System.Windows.Forms.Label LabelHostname;
        private System.Windows.Forms.TextBox InputIPAddress;
        private System.Windows.Forms.Timer InputTimer;
        private System.Windows.Forms.Button ButtonDeleteHost;
    }
}