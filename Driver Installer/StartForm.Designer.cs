namespace Driver_Installer
{
    partial class StartForm
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
            this.techButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // techButton
            // 
            this.techButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techButton.Location = new System.Drawing.Point(360, 130);
            this.techButton.Name = "techButton";
            this.techButton.Size = new System.Drawing.Size(220, 96);
            this.techButton.TabIndex = 0;
            this.techButton.Text = "Tech Tools";
            this.techButton.UseVisualStyleBackColor = true;
            this.techButton.Click += new System.EventHandler(this.techButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(266, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iadBtn
            // 
            this.iadBtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iadBtn.Location = new System.Drawing.Point(46, 130);
            this.iadBtn.Name = "iadBtn";
            this.iadBtn.Size = new System.Drawing.Size(220, 96);
            this.iadBtn.TabIndex = 3;
            this.iadBtn.Text = "Install A Driver";
            this.iadBtn.UseVisualStyleBackColor = true;
            this.iadBtn.Click += new System.EventHandler(this.iadBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 343);
            this.Controls.Add(this.iadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.techButton);
            this.Name = "StartForm";
            this.Text = "AOT Driver Installer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button techButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iadBtn;
    }
}

