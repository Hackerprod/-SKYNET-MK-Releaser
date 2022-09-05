using SKYNET.GUI;
using SKYNET.Helpers;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tik4net;
using tik4net.Objects;
using tik4net.Objects.Ip;
using tik4net.Objects.Ip.Firewall;
using tik4net.Objects.System;

namespace SKYNET
{
    public partial class frmMain : frmBase
    {
        private ITikConnection connection;
        private FirewallAddressList CurrentFirewallAddress;
        private bool _connected;

        private bool Connected
        {
            get
            {
                return _connected;
            }
            set
            {
                _connected = value;
                BT_Auth.Text = value ? "Disconnect" : "Connect";
                if (!value) ResetFields();
            }
        }

        public frmMain()
        {
            InitializeComponent();
            base.SetMouseMove(PN_Top);
            CheckForIllegalCrossThreadCalls = false;

            connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
            Connected = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Settings.Load();

            TB_Host.Text = Settings.Host;
            TB_Username.Text = Settings.Username;
            TB_Password.Text = Settings.Password;
            CH_AutoConnect.Checked = Settings.AutoConnect;
            CH_AutoRelease.Checked = Settings.AutoRelease;

            Task.Run(delegate
            {
                if (Settings.AutoRelease)
                {
                    BT_Auth_Click(null, null);
                    Thread.Sleep(500);
                    BT_Release_Click(null, null);
                }
                else if (Settings.AutoConnect)
                {
                    BT_Auth_Click(null, null);
                }
            });
        }

        public static string GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            IPAddress iPAddress = null;
            IPAddress[] addressList = hostEntry.AddressList;
            foreach (IPAddress address in addressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    iPAddress = address;
                }
            }
            return iPAddress.ToString();
        }

        private void CloseBox_BoxClicked(object sender, EventArgs e)
        {
            Settings.Host = TB_Host.Text;
            Settings.Username = TB_Username.Text;
            Settings.Password = TB_Password.Text;
            Settings.AutoConnect = CH_AutoConnect.Checked;
            Settings.AutoRelease = CH_AutoRelease.Checked;
            Settings.Save();

            Application.Exit();
        }

        private void MinimizeBox_BoxClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_Auth_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Connected)
                {
                    connection.Open(TB_Host.Text, TB_Username.Text, TB_Password.Text);

                    var sysRes = connection.LoadSingle<SystemResource>();

                    string IPAddress = GetIPAddress();

                    foreach (var AddressList in connection.LoadAll<FirewallAddressList>())
                    {
                        if (IPAddress == AddressList.Address)
                        {
                            CurrentFirewallAddress = AddressList;
                        }
                    }

                    LB_Host.Text = TB_Host.Text;
                    LB_ClientIP.Text = IPAddress;
                    LB_Interface.Text = CurrentFirewallAddress == null ? "Unknown Firewall Address List" : CurrentFirewallAddress.List;
                    LB_InterfaceComment.Text = CurrentFirewallAddress.Comment;
                    LB_OSVersion.Text = sysRes == null ? "Unknown OS version" : sysRes.Version;
                    LB_MikrotikModel.Text = sysRes == null ? "Unknown Mikrotik Model" : sysRes.BoardName;
                    LB_BoardCores.Text = sysRes == null ? "Unknown Board Cores" : sysRes.CpuCount.ToString();
                    LB_MemoryRAM.Text = sysRes == null ? "Unknown Memory RAM" : Common.LongToMbytes(sysRes.TotalMemory);
                    LB_TotalHddSpace.Text = sysRes == null ? "Unknown HDD space" : Common.LongToMbytes(sysRes.TotalHddSpace);
                    LB_ConnectionStatus.Text = "Connected";

                    Connected = true;

                    StartPing(TB_Host.Text);
                    WriteLine($"Client {CurrentFirewallAddress.Address} connected successfully");

                }
                else
                {
                    connection.Close();
                    Connected = false;
                }
            }
            catch
            {
                LB_ConnectionStatus.Text = "Disconnected";
                Connected = false;
                WriteLine($"Error connecting {CurrentFirewallAddress.Address} client");
            }
        }

        private void StartPing(string host)
        {
            Task.Run(delegate
            {
                while (Connected)
                {
                    Ping ping = new Ping();
                    int timeout = 100;
                    PingOptions pingOption = new PingOptions(16, true);
                    byte[] buffer = new byte[32];
                    try
                    {
                        PingReply pingReply = ping.Send(host, timeout, buffer, pingOption);

                        if (pingReply.Status == IPStatus.Success)
                        {
                            LB_PingStatus.Text = pingReply.RoundtripTime.ToString() + " ms";
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            LB_PingStatus.Text = "Offline"; 
                            Thread.Sleep(1000);
                        }
                    }
                    catch (Exception)
                    {
                        LB_PingStatus.Text = "Offline";
                        Thread.Sleep(1000);
                    }
                }
            });
            LB_PingStatus.Text = "Unknown"; 
        }

        private void BT_Release_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                WriteLine("Releasing DHCP client");
                foreach (var DhcpClient in connection.LoadAll<IpDhcpClient>())
                {
                    if (DhcpClient.Interface == CurrentFirewallAddress.List)
                    {
                        DhcpClient.Release(connection);
                        WriteLine($"Client {CurrentFirewallAddress.Address} with interface {CurrentFirewallAddress.List} released successfully");
                    }
                }
            }
            else
            {
                WriteLine("Please connect to Mikrotik first");
            }
        }

        private void ResetFields()
        {
            LB_Host.Text = "Unknown";
            LB_ClientIP.Text = "Unknown";
            LB_Interface.Text = "Unknown";
            LB_InterfaceComment.Text = "Unknown";
            LB_OSVersion.Text = "Unknown";
            LB_MikrotikModel.Text = "Unknown";
            LB_ConnectionStatus.Text = "Unknown";
            LB_PingStatus.Text = "Unknown";
            LB_BoardCores.Text = "Unknown";
            LB_MemoryRAM.Text = "Unknown";
            LB_TotalHddSpace.Text = "Unknown";
        }

        private void CH_AutoRelease_CheckedChanged(object sender, bool e)
        {
            if (CH_AutoRelease.Checked)
            {
                CH_AutoConnect.Checked = true;
            }
            else
            {
                CH_AutoConnect.Checked = Settings.AutoConnect;
            }
        }

        private void WriteLine(object msg)
        {
            LB_Info.Text = msg.ToString();
        }
    }
}
