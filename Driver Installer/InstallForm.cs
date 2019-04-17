using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace Driver_Installer
{
    public partial class InstallForm : Form
    {
        public InstallForm()
        {
            InitializeComponent();
            
        }
        private void InstallForm_Load(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}                     
        private void printerIP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void printerModel_SelectedIndexChanged(object sender, EventArgs e) { }
        private void printerName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void bwDef_CheckedChanged(object sender, EventArgs e) { }
        private void duplexDef_CheckedChanged(object sender, EventArgs e) { }
        private void testPage_CheckedChanged(object sender, EventArgs e) { }


        public void cmdLine(string command, string mod)
        {
                
                ProcessStartInfo psi = new ProcessStartInfo(command, mod);
                psi.Verb = "runas";
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                var proc = Process.Start(psi);
                string s = proc.StandardOutput.ReadToEnd();
                insProg.resbox.AppendText(s);
        }
        public bool driverExists()
        {
            System.Management.SelectQuery query = new System.Management.SelectQuery("Win32_SystemDriver");
            query.Condition = "Name = 'SomeDriverName'";

            System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query);
            var drivers = searcher.Get();
            
            if (drivers.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void pingPrinter()
        {
            
            string inputIP = printerIP.Text;
            cmdLine("ping", inputIP.ToString());
        }

        private void addDriver()
        {

        }


        public void startInstall_Click(object sender, EventArgs e)
        {
            ResultForm insProg = new ResultForm();
            insProg.Show();
            insProg.resbox.Text = "Checking if Driver is installed.";
            if (driverExists())
            {
                insProg.resbox.AppendText("Driver Found Attempting Communications with Printer");

            }
            else
            {
                insProg.resbox.AppendText("Driver Not Found Installing...");
            }
            

        }

        
      
    }
}
