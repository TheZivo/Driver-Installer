using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Driver_Installer
{
    public partial class TechToolsForm : Form
    {
        public TechToolsForm()
        {
            InitializeComponent();
        }
        public void cmdline(string command, string mod)
        {
            ResultForm outputf = new ResultForm();
            outputf.Show();
            ProcessStartInfo psi = new ProcessStartInfo(command, mod);
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);
            string s = proc.StandardOutput.ReadToEnd();
            outputf.resbox.Text = s;
        }

        private void TechToolsForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ipconfigBtn_Click(object sender, EventArgs e)
        {
            cmdline("ipconfig", " /all");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pingBtn_Click(object sender, EventArgs e)
        {
            string ip = PingIP.Text;
            cmdline("ping", ip);
        }

        private void PingIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void netScanBtn_Click(object sender, EventArgs e)
        {
            cmdline("arp", "-a");
        }

        private void spoolBtn_Click(object sender, EventArgs e)
        {
            cmdline("net stop spooler", "");
        }
    }    
}
