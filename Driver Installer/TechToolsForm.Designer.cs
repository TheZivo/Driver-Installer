namespace Driver_Installer
{
    partial class TechToolsForm
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
            this.spoolBtn = new System.Windows.Forms.Button();
            this.smbBtn = new System.Windows.Forms.Button();
            this.pingBtn = new System.Windows.Forms.Button();
            this.netScanBtn = new System.Windows.Forms.Button();
            this.ipconfigBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PingIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // spoolBtn
            // 
            this.spoolBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.spoolBtn.Location = new System.Drawing.Point(106, 119);
            this.spoolBtn.Name = "spoolBtn";
            this.spoolBtn.Size = new System.Drawing.Size(161, 66);
            this.spoolBtn.TabIndex = 0;
            this.spoolBtn.Text = "Restart Spooler";
            this.spoolBtn.UseVisualStyleBackColor = true;
            this.spoolBtn.Click += new System.EventHandler(this.spoolBtn_Click);
            // 
            // smbBtn
            // 
            this.smbBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.smbBtn.Location = new System.Drawing.Point(538, 162);
            this.smbBtn.Name = "smbBtn";
            this.smbBtn.Size = new System.Drawing.Size(113, 40);
            this.smbBtn.TabIndex = 1;
            this.smbBtn.Text = "Create";
            this.smbBtn.UseVisualStyleBackColor = true;
            // 
            // pingBtn
            // 
            this.pingBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.pingBtn.Location = new System.Drawing.Point(208, 342);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(113, 40);
            this.pingBtn.TabIndex = 2;
            this.pingBtn.Text = "Start";
            this.pingBtn.UseVisualStyleBackColor = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // netScanBtn
            // 
            this.netScanBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.netScanBtn.Location = new System.Drawing.Point(538, 342);
            this.netScanBtn.Name = "netScanBtn";
            this.netScanBtn.Size = new System.Drawing.Size(113, 40);
            this.netScanBtn.TabIndex = 3;
            this.netScanBtn.Text = "Start";
            this.netScanBtn.UseVisualStyleBackColor = true;
            this.netScanBtn.Click += new System.EventHandler(this.netScanBtn_Click);
            // 
            // ipconfigBtn
            // 
            this.ipconfigBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.ipconfigBtn.Location = new System.Drawing.Point(49, 342);
            this.ipconfigBtn.Name = "ipconfigBtn";
            this.ipconfigBtn.Size = new System.Drawing.Size(113, 40);
            this.ipconfigBtn.TabIndex = 4;
            this.ipconfigBtn.Text = "Start";
            this.ipconfigBtn.UseVisualStyleBackColor = true;
            this.ipconfigBtn.Click += new System.EventHandler(this.ipconfigBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "IPCONFIG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create an SMB Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(534, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Network Scan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(224, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ping Test";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox4.Location = new System.Drawing.Point(538, 119);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(113, 31);
            this.maskedTextBox4.TabIndex = 12;
            this.maskedTextBox4.Text = "Folder Name";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Technician Tools";
            // 
            // PingIP
            // 
            this.PingIP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.PingIP.Location = new System.Drawing.Point(208, 304);
            this.PingIP.Name = "PingIP";
            this.PingIP.Size = new System.Drawing.Size(113, 31);
            this.PingIP.TabIndex = 14;
            this.PingIP.Text = "IP Address";
            this.PingIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PingIP.TextChanged += new System.EventHandler(this.PingIP_TextChanged);
            // 
            // TechToolsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PingIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipconfigBtn);
            this.Controls.Add(this.netScanBtn);
            this.Controls.Add(this.pingBtn);
            this.Controls.Add(this.smbBtn);
            this.Controls.Add(this.spoolBtn);
            this.Name = "TechToolsForm";
            this.Text = "Tech Tools";
            this.Load += new System.EventHandler(this.TechToolsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spoolBtn;
        private System.Windows.Forms.Button smbBtn;
        private System.Windows.Forms.Button pingBtn;
        private System.Windows.Forms.Button netScanBtn;
        private System.Windows.Forms.Button ipconfigBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PingIP;
    }
}