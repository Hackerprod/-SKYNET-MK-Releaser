using SKYNET.GUI;
using SKYNET.Helpers;
using System;
using System.Collections.Generic;
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
        private SystemResource sysRes;
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

        public static List<string> GetIPAddress()
        {
            var Addresses = new List<string>();
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addressList = hostEntry.AddressList;
            foreach (IPAddress address in addressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Addresses.Add(address.ToString());
                }
            }
            return Addresses;
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
            BT_Auth.Enabled = false;
            Task.Run(delegate
            {
                try
                {
                    if (!IPAddress.TryParse(TB_Host.Text, out _))
                    {
                        Common.Show("The server ip address is not valid.");
                        return;
                    }
                    if (!Connected)
                    {
                        WriteLine($"Connecting to {TB_Host.Text}, please wait...");
                        connection.Open(TB_Host.Text, TB_Username.Text, TB_Password.Text);

                        sysRes = connection.LoadSingle<SystemResource>();
                        var ipAddress = "";

                        foreach (var AddressList in connection.LoadAll<FirewallAddressList>())
                        {
                            if (GetIPAddress().Contains(AddressList.Address))
                            {
                                CurrentFirewallAddress = AddressList;
                                ipAddress = AddressList.Address;
                            }
                        }

                        LB_Host.Text = TB_Host.Text;
                        LB_ClientIP.Text = ipAddress;
                        LB_Interface.Text = CurrentFirewallAddress == null ? "Unknown Firewall Address List" : CurrentFirewallAddress.List;
                        LB_InterfaceComment.Text = CurrentFirewallAddress?.Comment;
                        LB_OSVersion.Text = sysRes == null ? "Unknown OS version" : sysRes.Version;
                        LB_MikrotikModel.Text = sysRes == null ? "Unknown Mikrotik Model" : sysRes.BoardName;
                        LB_BoardCores.Text = sysRes == null ? "Unknown Board Cores" : sysRes.CpuCount.ToString();
                        LB_MemoryRAM.Text = sysRes == null ? "Unknown Memory RAM" : Common.LongToMbytes(sysRes.TotalMemory - sysRes.FreeMemory) + " / " + Common.LongToMbytes(sysRes.TotalMemory);
                        LB_TotalHddSpace.Text = sysRes == null ? "Unknown HDD space" : Common.LongToMbytes(sysRes.TotalHddSpace - sysRes.FreeHddSpace) + " / " + Common.LongToMbytes(sysRes.TotalHddSpace);
                        LB_ConnectionStatus.Text = "Connected";

                        Connected = true;

                        StartPing(TB_Host.Text);
                        WriteLine($"Client {CurrentFirewallAddress?.Address} connected successfully");
                        BT_Release.Enabled = true;
                    }
                    else
                    {
                        connection.Close();
                        Connected = false;
                        BT_Auth.Enabled = true;
                        BT_Release.Enabled = false;
                        WriteLine($"Client disconnected successfully");
                    }
                }
                catch
                {
                    LB_ConnectionStatus.Text = "Disconnected";
                    Connected = false;
                    WriteLine($"Error connecting to {TB_Host.Text}");
                    BT_Auth.Enabled = true;
                }
            });
        }

        private async void StartPing(string host)
        {
            while (Connected)
            {
                try
                {
                    TcpClient TcpClient = new TcpClient();

                    DateTime SentDateTime = DateTime.Now;

                    await TcpClient.ConnectAsync(host, 8728);

                    TimeSpan span = DateTime.Now - SentDateTime;
                    long RoundtripTime = span.Milliseconds;

                    LB_PingStatus.Text = RoundtripTime + " ms";

                    try
                    {
                        LB_MemoryRAM.Text = sysRes == null ? "Unknown Memory RAM" : Common.LongToMbytes(sysRes.TotalMemory - sysRes.FreeMemory) + " / " + Common.LongToMbytes(sysRes.TotalMemory);
                        LB_TotalHddSpace.Text = sysRes == null ? "Unknown HDD space" : Common.LongToMbytes(sysRes.TotalHddSpace - sysRes.FreeHddSpace) + " / " + Common.LongToMbytes(sysRes.TotalHddSpace);
                    }
                    catch
                    {
                    }

                    TcpClient.Close();

                    Thread.Sleep(1000);
                }
                catch
                {
                    LB_PingStatus.Text = "Offline";
                    Thread.Sleep(1000);
                }

            }

            LB_PingStatus.Text = "---";
            BT_Auth.Enabled = true;
        }

        private void BT_Release_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                WriteLine("Releasing DHCP client");
                var validInterface = GetValidInterface(CurrentFirewallAddress.List);
                foreach (var DhcpClient in connection.LoadAll<IpDhcpClient>())
                {
                    if (DhcpClient.Interface == validInterface)
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

        private string GetValidInterface(string List)
        {
            var validName = List;
            if (List.StartsWith("VPN_"))
            {
                validName = List.Replace("VPN_", "wlan");
            }
            return validName;
        }

        private void ResetFields()
        {
            LB_Host.Text = "---";
            LB_ClientIP.Text = "---";
            LB_Interface.Text = "---";
            LB_InterfaceComment.Text = "---";
            LB_OSVersion.Text = "---";
            LB_MikrotikModel.Text = "---";
            LB_ConnectionStatus.Text = "---";
            LB_PingStatus.Text = "---";
            LB_BoardCores.Text = "---";
            LB_MemoryRAM.Text = "---";
            LB_TotalHddSpace.Text = "---";
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

        private void Label4_Click(object sender, EventArgs e)
        {
            SaveToAddressList("10.0.0.1", "wlan1", "auto_ Hackerprod");
            SaveToAddressList("10.0.0.2", "wlan2", "Elier");
            SaveToAddressList("10.0.0.3", "wlan3", "Dairon");
            SaveToAddressList("10.0.0.4", "wlan4", "Alejandro");
            SaveToAddressList("10.0.0.5", "wlan5", "Harry");
            SaveToAddressList("10.0.0.6", "wlan1", "Hackerprod movil");
            SaveToAddressList("10.0.0.7", "wlan1", "Day movil");
            SaveToAddressList("10.0.0.8", "wlan8", "Yanelis Febles");
            SaveToAddressList("10.0.0.9", "wlan9", "Yoel Cricúa");
            SaveToAddressList("10.0.0.10", "wlan10", "Elier padre");
            SaveToAddressList("10.0.0.13", "wlan3", "Dairon movil");
            SaveToAddressList("10.0.0.14", "wlan4", "Alejandro movil");
            SaveToAddressList("10.0.0.15", "wlan15", "Arianné");
            SaveToAddressList("10.0.0.17", "wlan17", "Osmel barrio");
        }

        private void SaveToAddressList(string Address, string List, string Comment)
        {
            try
            {
                connection.Save(new FirewallAddressList()
                {
                    Address = Address,
                    List = List,
                    Comment = Comment
                });
            }
            catch 
            {
            }
        }

    }
}
