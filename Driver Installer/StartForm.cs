using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver_Installer
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void techButton_Click(object sender, EventArgs e)
        {
            TechToolsForm toolBox = new TechToolsForm();
            this.Hide();
            toolBox.ShowDialog();
            this.Close();
        }

        private void iadBtn_Click(object sender, EventArgs e)
        {
            InstallForm installer = new InstallForm();
            this.Hide();
            installer.ShowDialog();
            this.Close();
        }
    }
}
