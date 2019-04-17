namespace Driver_Installer
{
    partial class InstallForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.duplexDef = new System.Windows.Forms.CheckBox();
            this.bwDef = new System.Windows.Forms.CheckBox();
            this.startInstall = new System.Windows.Forms.Button();
            this.printerIP = new System.Windows.Forms.MaskedTextBox();
            this.printerModel = new System.Windows.Forms.ComboBox();
            this.printerName = new System.Windows.Forms.MaskedTextBox();
            this.testPage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(325, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Install";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(90, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(90, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Default Settings : ";
            // 
            // duplexDef
            // 
            this.duplexDef.AutoSize = true;
            this.duplexDef.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.duplexDef.Location = new System.Drawing.Point(282, 327);
            this.duplexDef.Name = "duplexDef";
            this.duplexDef.Size = new System.Drawing.Size(148, 23);
            this.duplexDef.TabIndex = 8;
            this.duplexDef.Text = "Default to Duplex";
            this.duplexDef.UseVisualStyleBackColor = true;
            this.duplexDef.CheckedChanged += new System.EventHandler(this.duplexDef_CheckedChanged);
            // 
            // bwDef
            // 
            this.bwDef.AutoSize = true;
            this.bwDef.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bwDef.Location = new System.Drawing.Point(282, 292);
            this.bwDef.Name = "bwDef";
            this.bwDef.Size = new System.Drawing.Size(132, 23);
            this.bwDef.TabIndex = 11;
            this.bwDef.Text = "Default to B/W";
            this.bwDef.UseVisualStyleBackColor = true;
            this.bwDef.CheckedChanged += new System.EventHandler(this.bwDef_CheckedChanged);
            // 
            // startInstall
            // 
            this.startInstall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.startInstall.Location = new System.Drawing.Point(535, 286);
            this.startInstall.Name = "startInstall";
            this.startInstall.Size = new System.Drawing.Size(155, 64);
            this.startInstall.TabIndex = 14;
            this.startInstall.Text = "Start";
            this.startInstall.UseVisualStyleBackColor = true;
            this.startInstall.Click += new System.EventHandler(this.startInstall_Click);
            // 
            // printerIP
            // 
            this.printerIP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.printerIP.Location = new System.Drawing.Point(252, 150);
            this.printerIP.Name = "printerIP";
            this.printerIP.Size = new System.Drawing.Size(162, 31);
            this.printerIP.TabIndex = 15;
            this.printerIP.Text = "Enter IP";
            this.printerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.printerIP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.printerIP_MaskInputRejected);
            // 
            // printerModel
            // 
            this.printerModel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerModel.FormattingEnabled = true;
            this.printerModel.Location = new System.Drawing.Point(252, 197);
            this.printerModel.Name = "printerModel";
            this.printerModel.Size = new System.Drawing.Size(162, 31);
            this.printerModel.TabIndex = 16;
            this.printerModel.Text = "    Machine Model";
            this.printerModel.SelectedIndexChanged += new System.EventHandler(this.printerModel_SelectedIndexChanged);
            // 
            // printerName
            // 
            this.printerName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.printerName.Location = new System.Drawing.Point(252, 244);
            this.printerName.Name = "printerName";
            this.printerName.Size = new System.Drawing.Size(162, 31);
            this.printerName.TabIndex = 17;
            this.printerName.Text = "Printer Name";
            this.printerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.printerName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.printerName_MaskInputRejected);
            // 
            // testPage
            // 
            this.testPage.AutoSize = true;
            this.testPage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.testPage.Location = new System.Drawing.Point(282, 365);
            this.testPage.Name = "testPage";
            this.testPage.Size = new System.Drawing.Size(142, 23);
            this.testPage.TabIndex = 18;
            this.testPage.Text = "Print a Test Page";
            this.testPage.UseVisualStyleBackColor = true;
            this.testPage.CheckedChanged += new System.EventHandler(this.testPage_CheckedChanged);
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testPage);
            this.Controls.Add(this.printerName);
            this.Controls.Add(this.printerModel);
            this.Controls.Add(this.printerIP);
            this.Controls.Add(this.startInstall);
            this.Controls.Add(this.bwDef);
            this.Controls.Add(this.duplexDef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InstallForm";
            this.Text = "Install A Driver";
            this.Load += new System.EventHandler(this.InstallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox duplexDef;
        private System.Windows.Forms.CheckBox bwDef;
        private System.Windows.Forms.Button startInstall;
        private System.Windows.Forms.MaskedTextBox printerIP;
        private System.Windows.Forms.ComboBox printerModel;
        private System.Windows.Forms.MaskedTextBox printerName;
        private System.Windows.Forms.CheckBox testPage;
    }
}