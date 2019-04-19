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
using System.Runtime.InteropServices;

namespace Driver_Installer
{
    public partial class InstallForm : Form
    {
        ResultForm insProg = new ResultForm();

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

        public string nl = "\r\n";
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
            query.Condition = "Name = 'KMUC74FP.DLL'";

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

        
        [DllImport("Setupapi.dll", EntryPoint = "InstallHinfSection", CallingConvention = CallingConvention.StdCall)]

        public static extern void InstallHinfSection(
            [In] IntPtr hwnd,
            [In] IntPtr ModuleHandle,
            [In, MarshalAs(UnmanagedType.LPWStr)] string CmdLineBuffer,
            int nCmdShow);

        public void addDriver()
        {
            string path = " ";
            if (System.Environment.Is64BitOperatingSystem)
            {
                path = ".\\64bit\\OEMSETUP.INF";
            }
            else
            {
                path = ".\\32bit\\OEMSETUP.INF";
            }
            InstallHinfSection(IntPtr.Zero, IntPtr.Zero, path, 0);
        }

        public void addPrinter()
        {
            
        }

    public void startInstall_Click(object sender, EventArgs e)
        {
            
            insProg.Show();
            insProg.resbox.Text = "Checking if Driver is installed..." + nl;
            if (driverExists())
            {
                insProg.resbox.AppendText("Driver Found" + nl);

            }
            else
            {
                insProg.resbox.AppendText("Driver Not Found Installing..." + nl);
                addDriver();
                insProg.resbox.AppendText("Driver Has Been Installed" + nl);
            }
            insProg.resbox.AppendText("Attempting Communications with printer at provided IP");
            pingPrinter();
            insProg.resbox.AppendText("Adding Printer...");
            addPrinter();

        }

        
      
    }
}
