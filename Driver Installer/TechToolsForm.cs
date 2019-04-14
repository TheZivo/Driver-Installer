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

        /* Used to ping the current network for occupied IP addresses and get their Hostname back if possible
         Some equipment will not provide a hostname back, typically networking equipment and VoIP phones. 
         As the network scanner is being used to show available IPs and Machines these values will be added to a seperate
         dictionary to be printed after. 
        */
        public void Scanner()
        {
            MainThread = SynchronizationContext.Current;
            if (MainThread == null) MainThread = new SynchronizationContext();
            ResultForm pingsweep = new ResultForm();
            pingsweep.Show();
            Ping pingTest;
            PingReply reply;
            IPAddress addy;
            IPHostEntry host;

            var subnet = getsubnet();
            var found = new ConcurrentDictionary<string, string>();
            var notFound = new ConcurrentBag<string>();
            var occupied = new ConcurrentBag<string>();

            Parallel.For(0, 256, (i) =>
            {
                string itSubnet = "." + i.ToString();
                pingTest = new Ping();
                reply = pingTest.Send(subnet + itSubnet, 300);
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

            MainThread.Send((object state) => {
                pingsweep.resbox.AppendText("Found the following hosts: " + System.Environment.NewLine);


/*
                foreach (KeyValuePair<string, string> kvp in found.OrderBy(x => x.Key))
                {
                    pingsweep.resbox.AppendText(kvp.Value + " at " + kvp.Key + System.Environment.NewLine);
                }
*/                               
            }, null); 
                                                                        
/*
            for ( int i = 0; i < 254; i++)
            {
                string itSubnet = "." + i.ToString();
                pingTest = new Ping();
                reply = pingTest.Send(subnet + itSubnet, 300);
                var s = "";
                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                        addy = IPAddress.Parse(subnet + itSubnet);
                        host = Dns.GetHostEntry(addy);
                        s = subnet + itSubnet + host.HostName.ToString() + System.Environment.NewLine;
                        pingsweep.resbox.AppendText(s);
                        //found.TryAdd(itSubnet, addy.ToString());
                    }
                    catch (Exception e)
                    {
                        pingsweep.resbox.AppendText(e.Message + ": " + subnet + itSubnet + System.Environment.NewLine);
                    }
                }
                else
                {
                    pingsweep.resbox.AppendText(subnet + itSubnet + " Inactive" + System.Environment.NewLine);
                    //notFound.TryAdd(itSubnet, subnet + itSubnet);
                }
            };


            //Console.WriteLine("Found the following hosts: ");
            //foreach (var iterHost in found.OrderBy(x => x.Key).Select(x => x.Value))
            //{
              //  Console.WriteLine(iterHost);
            //}
            //Console.ReadLine();
*/
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

        //Runs an IP config /all command to provide network information

        private void ipconfigBtn_Click(object sender, EventArgs e)
        {
            Cmdline("ipconfig", " /all");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Runs a ping test to provided IP, after parsing the text and checking for correct input.
        private void pingBtn_Click(object sender, EventArgs e)
        {

            //CHECK INPUT 
            string ip = PingIP.Text;
            Cmdline("ping", ip);
        }

        private void PingIP_TextChanged(object sender, EventArgs e)
        {

        }

        // Runs network scan of current network by passing getsubnet function to Scanner 
        public void netScanBtn_Click(object sender, EventArgs e)
        {
            scanTh = new Thread(new ThreadStart(Scanner));
            scanTh.Start();


        }
        // Stops then restarts the Print Spooler, something people constantly tell me helps but I have never actually needed..
        private void spoolBtn_Click(object sender, EventArgs e)
        {
            // Make work 
            Cmdline("net stop spooler", "");
        }
    }    
}
