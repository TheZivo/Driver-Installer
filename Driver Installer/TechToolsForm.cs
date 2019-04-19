using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Project Specific: 
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Collections.Concurrent;


namespace Driver_Installer
{
    public partial class TechToolsForm : Form
    {
        public string nl = "\r\n";
        //declare thread for scanner and context for mainthread
        public Thread scanTh;
        public SynchronizationContext MainThread;


        public TechToolsForm()
        {
            InitializeComponent();
            
        }

        //Used to run various command line prompts for techs.
        public void Cmdline(string command, string mod)
        {
            ResultForm outputf = new ResultForm();
            outputf.Show();
            ProcessStartInfo psi = new ProcessStartInfo(command, mod);
            psi.Verb = "runas";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);
            string s = proc.StandardOutput.ReadToEnd();
            outputf.resbox.Text = s;
        }

        //Used to provide the first three octets of the machines current IP for use in the network scanner.
        public static string getsubnet()
        {

            string myHost = Dns.GetHostName();
            string myIP = Dns.GetHostByName(myHost).AddressList[0].ToString();
            List<string> octet = myIP.Split('.').ToList();
            octet.RemoveAt(3);
            string subnet = String.Join(".", octet);
            return subnet;

        }

        public static ConcurrentDictionary<string, string> found = new ConcurrentDictionary<string, string> { };
        public static ConcurrentBag<string> notFound = new ConcurrentBag<string>();
        public static ConcurrentBag<string> occupied = new ConcurrentBag<string>();

        /* Used to ping the current network for occupied IP addresses and get their Hostname back if possible
         Some equipment will not provide a hostname back, typically networking equipment and VoIP phones. 
         As the network scanner is being used to show available IPs and Machines these values will be added to a seperate
         dictionary to be printed after. 
        */
        public void Scanner()
        {            
            //init this thread as main
            MainThread = SynchronizationContext.Current;
            if (MainThread == null) MainThread = new SynchronizationContext();

            // create new instance of loading screen

            ProgressForm running = new ProgressForm();
            running.Show();
            
            //Runs scanLoop to fill dictionaries and bags
            scanLoop();        
            
            //When scanLoop ends the loading screen is closed
            running.Close();

            //create new instance of resultform for host/ip pairs to display
            ResultForm pingsweep = new ResultForm();
            pingsweep.Show();

            pingsweep.resbox.Text = "Found the following hosts:" + nl + nl;
            foreach (var iterHost in found.OrderBy(x => x.Key).Select(x => x.Value))
            {
                pingsweep.resbox.AppendText(iterHost + nl);
            }

            pingsweep.resbox.AppendText
                (Environment.NewLine + "Found the following Occupied IP's:" + nl + nl);
            foreach (var takenIP in occupied.OrderBy(x => x))
            {
                pingsweep.resbox.AppendText(takenIP + nl); 
            };

            found = new ConcurrentDictionary<string, string>();
            occupied = new ConcurrentBag<string>();


        }

         public void scanLoop()
            {
            //declare variables used in loop
            Ping pingTest;
            PingReply reply;
            IPAddress addy;
            IPHostEntry host;
            var subnet = getsubnet();
            
            //loop through IP's on the current subnet ping each then store result in correct dict or bag
            Parallel.For(0, 256, (i) =>
                {
                    //Pinging
                    string itSubnet = "." + i.ToString();
                    pingTest = new Ping();
                    reply = pingTest.Send(subnet + itSubnet, 300);

                    //Storing
                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            addy = IPAddress.Parse(subnet + itSubnet);
                            host = Dns.GetHostEntry(addy);
                            found.TryAdd(subnet + itSubnet, host.HostName.ToString());
                        }
                        catch (Exception)
                        {
                            occupied.Add(subnet + itSubnet);
                        }
                    }

                    else
                    {
                        notFound.Add(subnet + itSubnet);
                    }
                });
            }                    

        private void TechToolsForm_Load(object sender, EventArgs e) { }
        
        private void label4_Click(object sender, EventArgs e) { }
        private void PingIP_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        //Runs an IP config /all command to provide network information

        private void ipconfigBtn_Click(object sender, EventArgs e)
        {
            Cmdline("ipconfig", " /all");
        }    

        //Runs a ping test to provided IP, after parsing the text and checking for correct input.
        private void pingBtn_Click(object sender, EventArgs e)
        {
            //CHECK INPUT 
            string ip = PingIP.Text;
            Cmdline("ping", ip);
        }

        // Runs network scan of current network by passing getsubnet function to Scanner 
        public void netScanBtn_Click(object sender, EventArgs e)
        {
            Scanner();                       
        }

        // Stops then restarts the Print Spooler, something people constantly tell me helps but I have never actually needed..
        private void spoolBtn_Click(object sender, EventArgs e)
        {
            

            Process cmd = new Process();
            ResultForm spoolrun = new ResultForm();
            spoolrun.Show();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("cd c:");
            cmd.StandardInput.WriteLine("net start spooler");
            //cmd.StandardInput.WriteLine("net start spooler");
            //cmd.StandardInput.WriteLine("exit");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            spoolrun.resbox.Text = cmd.StandardOutput.ReadToEnd();




            //Cmdline("net stop spooler", "");
        }
    }    
}
