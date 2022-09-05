namespace SKYNET
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BT_Auth = new SKYNET_Button();
            this.PN_Top = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.skyneT_Box3 = new SKYNET.Controls.SKYNET_Box();
            this.MinimizeBox = new SKYNET.Controls.SKYNET_Box();
            this.CloseBox = new SKYNET.Controls.SKYNET_Box();
            this.BT_Release = new SKYNET_Button();
            this.TB_Host = new SKYNET.Controls.SKYNET_TextBox();
            this.TB_Username = new SKYNET.Controls.SKYNET_TextBox();
            this.TB_Password = new SKYNET.Controls.SKYNET_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_BoardCores = new System.Windows.Forms.Label();
            this.LB_TotalHddSpace = new System.Windows.Forms.Label();
            this.LB_MemoryRAM = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.LB_PingStatus = new System.Windows.Forms.Label();
            this.LB_ConnectionStatus = new System.Windows.Forms.Label();
            this.LB_MikrotikModel = new System.Windows.Forms.Label();
            this.LB_OSVersion = new System.Windows.Forms.Label();
            this.LB_InterfaceComment = new System.Windows.Forms.Label();
            this.LB_Interface = new System.Windows.Forms.Label();
            this.LB_ClientIP = new System.Windows.Forms.Label();
            this.LB_Host = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_Info = new System.Windows.Forms.Label();
            this.CH_AutoConnect = new SKYNET.Controls.SKYNET_Check();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CH_AutoRelease = new SKYNET.Controls.SKYNET_Check();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PN_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Auth
            // 
            this.BT_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.BT_Auth.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Auth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_Auth.ForeColor = System.Drawing.Color.White;
            this.BT_Auth.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Auth.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.BT_Auth.ImageIcon = null;
            this.BT_Auth.Location = new System.Drawing.Point(30, 318);
            this.BT_Auth.MenuMode = false;
            this.BT_Auth.Name = "BT_Auth";
            this.BT_Auth.Rounded = false;
            this.BT_Auth.Size = new System.Drawing.Size(220, 32);
            this.BT_Auth.Style = SKYNET_Button._Style.TextOnly;
            this.BT_Auth.TabIndex = 1;
            this.BT_Auth.Text = "Connect";
            this.BT_Auth.Click += new System.EventHandler(this.BT_Auth_Click);
            // 
            // PN_Top
            // 
            this.PN_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.PN_Top.Controls.Add(this.label4);
            this.PN_Top.Controls.Add(this.skyneT_Box3);
            this.PN_Top.Controls.Add(this.MinimizeBox);
            this.PN_Top.Controls.Add(this.CloseBox);
            this.PN_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Top.Location = new System.Drawing.Point(0, 0);
            this.PN_Top.Name = "PN_Top";
            this.PN_Top.Size = new System.Drawing.Size(624, 27);
            this.PN_Top.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mikrotik Releaser";
            // 
            // skyneT_Box3
            // 
            this.skyneT_Box3.Color = System.Drawing.Color.Empty;
            this.skyneT_Box3.Dock = System.Windows.Forms.DockStyle.Right;
            this.skyneT_Box3.FocusedColor = System.Drawing.Color.Empty;
            this.skyneT_Box3.Image = null;
            this.skyneT_Box3.Location = new System.Drawing.Point(522, 0);
            this.skyneT_Box3.MaximumSize = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.MinimumSize = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.Name = "skyneT_Box3";
            this.skyneT_Box3.Size = new System.Drawing.Size(34, 26);
            this.skyneT_Box3.TabIndex = 2;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.MinimizeBox.Color = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.MinimizeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.MinimizeBox.Image = global::SKYNET.Properties.Resources.minimise;
            this.MinimizeBox.Location = new System.Drawing.Point(556, 0);
            this.MinimizeBox.MaximumSize = new System.Drawing.Size(34, 26);
            this.MinimizeBox.MinimumSize = new System.Drawing.Size(34, 26);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(34, 26);
            this.MinimizeBox.TabIndex = 1;
            this.MinimizeBox.BoxClicked += new System.EventHandler(this.MinimizeBox_BoxClicked);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.CloseBox.Color = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.CloseBox.Image = global::SKYNET.Properties.Resources.close;
            this.CloseBox.Location = new System.Drawing.Point(590, 0);
            this.CloseBox.MaximumSize = new System.Drawing.Size(34, 26);
            this.CloseBox.MinimumSize = new System.Drawing.Size(34, 26);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(34, 26);
            this.CloseBox.TabIndex = 0;
            this.CloseBox.BoxClicked += new System.EventHandler(this.CloseBox_BoxClicked);
            // 
            // BT_Release
            // 
            this.BT_Release.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.BT_Release.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Release.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Release.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_Release.ForeColor = System.Drawing.Color.White;
            this.BT_Release.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Release.ImageAlignment = SKYNET_Button._ImgAlign.Left;
            this.BT_Release.ImageIcon = null;
            this.BT_Release.Location = new System.Drawing.Point(14, 267);
            this.BT_Release.MenuMode = false;
            this.BT_Release.Name = "BT_Release";
            this.BT_Release.Rounded = false;
            this.BT_Release.Size = new System.Drawing.Size(278, 32);
            this.BT_Release.Style = SKYNET_Button._Style.TextOnly;
            this.BT_Release.TabIndex = 3;
            this.BT_Release.Text = "Release";
            this.BT_Release.Click += new System.EventHandler(this.BT_Release_Click);
            // 
            // TB_Host
            // 
            this.TB_Host.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Host.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Host.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Host.ForeColor = System.Drawing.Color.White;
            this.TB_Host.IsPassword = false;
            this.TB_Host.Location = new System.Drawing.Point(30, 71);
            this.TB_Host.Logo = global::SKYNET.Properties.Resources.networking_manager_100px;
            this.TB_Host.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Host.Multiline = false;
            this.TB_Host.Name = "TB_Host";
            this.TB_Host.OnlyNumbers = false;
            this.TB_Host.ShowLogo = true;
            this.TB_Host.Size = new System.Drawing.Size(220, 35);
            this.TB_Host.TabIndex = 4;
            this.TB_Host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Username
            // 
            this.TB_Username.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Username.ForeColor = System.Drawing.Color.White;
            this.TB_Username.IsPassword = false;
            this.TB_Username.Location = new System.Drawing.Point(30, 135);
            this.TB_Username.Logo = global::SKYNET.Properties.Resources.male_user_100px;
            this.TB_Username.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Username.Multiline = false;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.OnlyNumbers = false;
            this.TB_Username.ShowLogo = true;
            this.TB_Username.Size = new System.Drawing.Size(220, 35);
            this.TB_Username.TabIndex = 5;
            this.TB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Password
            // 
            this.TB_Password.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.TB_Password.ForeColor = System.Drawing.Color.White;
            this.TB_Password.IsPassword = true;
            this.TB_Password.Location = new System.Drawing.Point(30, 196);
            this.TB_Password.Logo = global::SKYNET.Properties.Resources.key_2_60px;
            this.TB_Password.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Password.Multiline = false;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.OnlyNumbers = false;
            this.TB_Password.ShowLogo = true;
            this.TB_Password.Size = new System.Drawing.Size(220, 35);
            this.TB_Password.TabIndex = 6;
            this.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connect To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.LB_BoardCores);
            this.panel1.Controls.Add(this.LB_TotalHddSpace);
            this.panel1.Controls.Add(this.LB_MemoryRAM);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.LB_PingStatus);
            this.panel1.Controls.Add(this.LB_ConnectionStatus);
            this.panel1.Controls.Add(this.LB_MikrotikModel);
            this.panel1.Controls.Add(this.LB_OSVersion);
            this.panel1.Controls.Add(this.LB_InterfaceComment);
            this.panel1.Controls.Add(this.LB_Interface);
            this.panel1.Controls.Add(this.LB_ClientIP);
            this.panel1.Controls.Add(this.LB_Host);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BT_Release);
            this.panel1.Location = new System.Drawing.Point(281, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 305);
            this.panel1.TabIndex = 10;
            // 
            // LB_BoardCores
            // 
            this.LB_BoardCores.AutoSize = true;
            this.LB_BoardCores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BoardCores.ForeColor = System.Drawing.Color.White;
            this.LB_BoardCores.Location = new System.Drawing.Point(132, 145);
            this.LB_BoardCores.Name = "LB_BoardCores";
            this.LB_BoardCores.Size = new System.Drawing.Size(61, 17);
            this.LB_BoardCores.TabIndex = 30;
            this.LB_BoardCores.Text = "Unknown";
            // 
            // LB_TotalHddSpace
            // 
            this.LB_TotalHddSpace.AutoSize = true;
            this.LB_TotalHddSpace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalHddSpace.ForeColor = System.Drawing.Color.White;
            this.LB_TotalHddSpace.Location = new System.Drawing.Point(132, 188);
            this.LB_TotalHddSpace.Name = "LB_TotalHddSpace";
            this.LB_TotalHddSpace.Size = new System.Drawing.Size(61, 17);
            this.LB_TotalHddSpace.TabIndex = 29;
            this.LB_TotalHddSpace.Text = "Unknown";
            // 
            // LB_MemoryRAM
            // 
            this.LB_MemoryRAM.AutoSize = true;
            this.LB_MemoryRAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MemoryRAM.ForeColor = System.Drawing.Color.White;
            this.LB_MemoryRAM.Location = new System.Drawing.Point(132, 166);
            this.LB_MemoryRAM.Name = "LB_MemoryRAM";
            this.LB_MemoryRAM.Size = new System.Drawing.Size(61, 17);
            this.LB_MemoryRAM.TabIndex = 28;
            this.LB_MemoryRAM.Text = "Unknown";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(11, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 17);
            this.label20.TabIndex = 26;
            this.label20.Text = "Ping:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(11, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 17);
            this.label21.TabIndex = 25;
            this.label21.Text = "Connection Status:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(11, 188);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 17);
            this.label33.TabIndex = 24;
            this.label33.Text = "Hdd Space:";
            // 
            // LB_PingStatus
            // 
            this.LB_PingStatus.AutoSize = true;
            this.LB_PingStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PingStatus.ForeColor = System.Drawing.Color.White;
            this.LB_PingStatus.Location = new System.Drawing.Point(132, 231);
            this.LB_PingStatus.Name = "LB_PingStatus";
            this.LB_PingStatus.Size = new System.Drawing.Size(61, 17);
            this.LB_PingStatus.TabIndex = 23;
            this.LB_PingStatus.Text = "Unknown";
            // 
            // LB_ConnectionStatus
            // 
            this.LB_ConnectionStatus.AutoSize = true;
            this.LB_ConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.LB_ConnectionStatus.Location = new System.Drawing.Point(132, 210);
            this.LB_ConnectionStatus.Name = "LB_ConnectionStatus";
            this.LB_ConnectionStatus.Size = new System.Drawing.Size(61, 17);
            this.LB_ConnectionStatus.TabIndex = 22;
            this.LB_ConnectionStatus.Text = "Unknown";
            // 
            // LB_MikrotikModel
            // 
            this.LB_MikrotikModel.AutoSize = true;
            this.LB_MikrotikModel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MikrotikModel.ForeColor = System.Drawing.Color.White;
            this.LB_MikrotikModel.Location = new System.Drawing.Point(132, 102);
            this.LB_MikrotikModel.Name = "LB_MikrotikModel";
            this.LB_MikrotikModel.Size = new System.Drawing.Size(61, 17);
            this.LB_MikrotikModel.TabIndex = 21;
            this.LB_MikrotikModel.Text = "Unknown";
            // 
            // LB_OSVersion
            // 
            this.LB_OSVersion.AutoSize = true;
            this.LB_OSVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_OSVersion.ForeColor = System.Drawing.Color.White;
            this.LB_OSVersion.Location = new System.Drawing.Point(132, 124);
            this.LB_OSVersion.Name = "LB_OSVersion";
            this.LB_OSVersion.Size = new System.Drawing.Size(61, 17);
            this.LB_OSVersion.TabIndex = 20;
            this.LB_OSVersion.Text = "Unknown";
            // 
            // LB_InterfaceComment
            // 
            this.LB_InterfaceComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_InterfaceComment.ForeColor = System.Drawing.Color.White;
            this.LB_InterfaceComment.Location = new System.Drawing.Point(132, 81);
            this.LB_InterfaceComment.Name = "LB_InterfaceComment";
            this.LB_InterfaceComment.Size = new System.Drawing.Size(160, 17);
            this.LB_InterfaceComment.TabIndex = 19;
            this.LB_InterfaceComment.Text = "Unknown";
            // 
            // LB_Interface
            // 
            this.LB_Interface.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Interface.ForeColor = System.Drawing.Color.White;
            this.LB_Interface.Location = new System.Drawing.Point(132, 60);
            this.LB_Interface.Name = "LB_Interface";
            this.LB_Interface.Size = new System.Drawing.Size(160, 17);
            this.LB_Interface.TabIndex = 18;
            this.LB_Interface.Text = "Unknown";
            // 
            // LB_ClientIP
            // 
            this.LB_ClientIP.AutoSize = true;
            this.LB_ClientIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ClientIP.ForeColor = System.Drawing.Color.White;
            this.LB_ClientIP.Location = new System.Drawing.Point(132, 39);
            this.LB_ClientIP.Name = "LB_ClientIP";
            this.LB_ClientIP.Size = new System.Drawing.Size(61, 17);
            this.LB_ClientIP.TabIndex = 17;
            this.LB_ClientIP.Text = "Unknown";
            // 
            // LB_Host
            // 
            this.LB_Host.AutoSize = true;
            this.LB_Host.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Host.ForeColor = System.Drawing.Color.White;
            this.LB_Host.Location = new System.Drawing.Point(132, 17);
            this.LB_Host.Name = "LB_Host";
            this.LB_Host.Size = new System.Drawing.Size(61, 17);
            this.LB_Host.TabIndex = 16;
            this.LB_Host.Text = "Unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Memory RAM:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Board cores:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "OS version:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mikrotik model:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Interface comment:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Interface:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Client IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Host:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.LB_Info);
            this.panel2.Location = new System.Drawing.Point(30, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 33);
            this.panel2.TabIndex = 11;
            // 
            // LB_Info
            // 
            this.LB_Info.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.LB_Info.ForeColor = System.Drawing.Color.White;
            this.LB_Info.Location = new System.Drawing.Point(6, 8);
            this.LB_Info.Name = "LB_Info";
            this.LB_Info.Size = new System.Drawing.Size(551, 17);
            this.LB_Info.TabIndex = 20;
            // 
            // CH_AutoConnect
            // 
            this.CH_AutoConnect.BackColor = System.Drawing.Color.Transparent;
            this.CH_AutoConnect.Checked = false;
            this.CH_AutoConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CH_AutoConnect.Location = new System.Drawing.Point(216, 242);
            this.CH_AutoConnect.Name = "CH_AutoConnect";
            this.CH_AutoConnect.Size = new System.Drawing.Size(34, 25);
            this.CH_AutoConnect.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Connect at startup";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(27, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Release client at startup";
            // 
            // CH_AutoRelease
            // 
            this.CH_AutoRelease.BackColor = System.Drawing.Color.Transparent;
            this.CH_AutoRelease.Checked = false;
            this.CH_AutoRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CH_AutoRelease.Location = new System.Drawing.Point(216, 282);
            this.CH_AutoRelease.Name = "CH_AutoRelease";
            this.CH_AutoRelease.Size = new System.Drawing.Size(34, 25);
            this.CH_AutoRelease.TabIndex = 14;
            this.CH_AutoRelease.CheckedChanged += new System.EventHandler<bool>(this.CH_AutoRelease_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.panel3.Location = new System.Drawing.Point(31, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 1);
            this.panel3.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(624, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CH_AutoRelease);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CH_AutoConnect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.TB_Host);
            this.Controls.Add(this.PN_Top);
            this.Controls.Add(this.BT_Auth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1360, 728);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PN_Top.ResumeLayout(false);
            this.PN_Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SKYNET_Button BT_Auth;
        private System.Windows.Forms.Panel PN_Top;
        private Controls.SKYNET_Box skyneT_Box3;
        private Controls.SKYNET_Box MinimizeBox;
        private Controls.SKYNET_Box CloseBox;
        private SKYNET_Button BT_Release;
        private Controls.SKYNET_TextBox TB_Host;
        private Controls.SKYNET_TextBox TB_Username;
        private Controls.SKYNET_TextBox TB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Host;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_PingStatus;
        private System.Windows.Forms.Label LB_ConnectionStatus;
        private System.Windows.Forms.Label LB_MikrotikModel;
        private System.Windows.Forms.Label LB_OSVersion;
        private System.Windows.Forms.Label LB_InterfaceComment;
        private System.Windows.Forms.Label LB_Interface;
        private System.Windows.Forms.Label LB_ClientIP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_Info;
        private Controls.SKYNET_Check CH_AutoConnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Controls.SKYNET_Check CH_AutoRelease;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LB_BoardCores;
        private System.Windows.Forms.Label LB_TotalHddSpace;
        private System.Windows.Forms.Label LB_MemoryRAM;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label33;
    }
}

