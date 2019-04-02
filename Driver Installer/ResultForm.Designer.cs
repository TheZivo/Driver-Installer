namespace Driver_Installer
{
    partial class ResultForm
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
            this.resbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resbox
            // 
            this.resbox.Location = new System.Drawing.Point(15, 50);
            this.resbox.Multiline = true;
            this.resbox.Name = "resbox";
            this.resbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resbox.Size = new System.Drawing.Size(750, 350);
            this.resbox.TabIndex = 0;
            this.resbox.TextChanged += new System.EventHandler(this.resbox_TextChanged);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.resbox);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox resbox;
    }
}