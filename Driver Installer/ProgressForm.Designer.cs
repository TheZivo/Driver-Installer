namespace Driver_Installer
{
    partial class ProgressForm
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
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.cancelOp = new System.Windows.Forms.Button();
            this.ProcessingText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoadingBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadingBar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoadingBar.Location = new System.Drawing.Point(100, 176);
            this.LoadingBar.MarqueeAnimationSpeed = 50;
            this.LoadingBar.Maximum = 255;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(590, 47);
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.TabIndex = 0;
            // 
            // cancelOp
            // 
            this.cancelOp.Location = new System.Drawing.Point(577, 346);
            this.cancelOp.Name = "cancelOp";
            this.cancelOp.Size = new System.Drawing.Size(75, 23);
            this.cancelOp.TabIndex = 1;
            this.cancelOp.Text = "Cancel";
            this.cancelOp.UseVisualStyleBackColor = true;
            // 
            // ProcessingText
            // 
            this.ProcessingText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.ProcessingText.Location = new System.Drawing.Point(289, 66);
            this.ProcessingText.Name = "ProcessingText";
            this.ProcessingText.Size = new System.Drawing.Size(215, 31);
            this.ProcessingText.TabIndex = 2;
            this.ProcessingText.Text = "Processing Please Wait";
            this.ProcessingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProcessingText);
            this.Controls.Add(this.cancelOp);
            this.Controls.Add(this.LoadingBar);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Button cancelOp;
        private System.Windows.Forms.TextBox ProcessingText;
    }
}