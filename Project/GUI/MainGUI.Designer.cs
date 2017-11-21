using System.Windows.Forms;
using GUI.UserControls;

namespace GUI
{
    partial class MainGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelsideMenu = new System.Windows.Forms.Panel();
            this.btnInfoApplication = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnManagement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDebt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.nMainElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sideMain = new System.Windows.Forms.Panel();
            this.ucInfoApplication = new GUI.UserControls.ucMainInfoApplication();
            this.ucStaff = new GUI.UserControls.ucMainStaff();
            this.ucDebt = new GUI.UserControls.ucMainDebt();
            this.ucManagement = new GUI.UserControls.ucMainManagement();
            this.ucList = new GUI.UserControls.ucMainList();
            this.ucHome = new GUI.UserControls.ucMainHome();
            this.header.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelsideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoApplication)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sideMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.menuStripLogin);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnExit);
            this.header.Controls.Add(this.btnMenu);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1071, 49);
            this.header.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(51, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trung tâm anh ngữ";
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStripLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStripLogin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStripLogin.Location = new System.Drawing.Point(866, 9);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripLogin.Size = new System.Drawing.Size(123, 60);
            this.menuStripLogin.TabIndex = 3;
            this.menuStripLogin.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnLogout});
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(207, 32);
            this.btnChangePassword.Text = "Đổi mật khẩu";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 32);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(993, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1028, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 20;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(16, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 20;
            // 
            // panelsideMenu
            // 
            this.panelsideMenu.BackColor = System.Drawing.Color.White;
            this.panelsideMenu.Controls.Add(this.btnInfoApplication);
            this.panelsideMenu.Controls.Add(this.btnManagement);
            this.panelsideMenu.Controls.Add(this.btnList);
            this.panelsideMenu.Controls.Add(this.btnDebt);
            this.panelsideMenu.Controls.Add(this.btnHome);
            this.panelsideMenu.Controls.Add(this.btnStaff);
            this.panelsideMenu.Controls.Add(this.panel3);
            this.panelsideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsideMenu.Location = new System.Drawing.Point(0, 49);
            this.panelsideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelsideMenu.Name = "panelsideMenu";
            this.panelsideMenu.Size = new System.Drawing.Size(267, 557);
            this.panelsideMenu.TabIndex = 1;
            // 
            // btnInfoApplication
            // 
            this.btnInfoApplication.BackColor = System.Drawing.Color.White;
            this.btnInfoApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoApplication.Image")));
            this.btnInfoApplication.ImageActive = null;
            this.btnInfoApplication.Location = new System.Drawing.Point(227, 523);
            this.btnInfoApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoApplication.Name = "btnInfoApplication";
            this.btnInfoApplication.Size = new System.Drawing.Size(33, 31);
            this.btnInfoApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfoApplication.TabIndex = 2;
            this.btnInfoApplication.TabStop = false;
            this.btnInfoApplication.Tag = "";
            this.btnInfoApplication.Zoom = 20;
            this.btnInfoApplication.Click += new System.EventHandler(this.btnInfoApplication_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnManagement.BackColor = System.Drawing.Color.White;
            this.btnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManagement.BorderRadius = 0;
            this.btnManagement.ButtonText = "Quản lý";
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.DisabledColor = System.Drawing.Color.Gray;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManagement.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManagement.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManagement.Iconimage")));
            this.btnManagement.Iconimage_right = null;
            this.btnManagement.Iconimage_right_Selected = null;
            this.btnManagement.Iconimage_Selected = null;
            this.btnManagement.IconMarginLeft = 0;
            this.btnManagement.IconMarginRight = 0;
            this.btnManagement.IconRightVisible = true;
            this.btnManagement.IconRightZoom = 0D;
            this.btnManagement.IconVisible = true;
            this.btnManagement.IconZoom = 50D;
            this.btnManagement.IsTab = true;
            this.btnManagement.Location = new System.Drawing.Point(0, 324);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Normalcolor = System.Drawing.Color.White;
            this.btnManagement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnManagement.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnManagement.selected = false;
            this.btnManagement.Size = new System.Drawing.Size(267, 59);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Quản lý";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManagement.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnManagement.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnList
            // 
            this.btnList.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnList.BackColor = System.Drawing.Color.White;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnList.BorderRadius = 0;
            this.btnList.ButtonText = "Danh sách";
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.DisabledColor = System.Drawing.Color.Gray;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnList.Iconimage")));
            this.btnList.Iconimage_right = null;
            this.btnList.Iconimage_right_Selected = null;
            this.btnList.Iconimage_Selected = null;
            this.btnList.IconMarginLeft = 0;
            this.btnList.IconMarginRight = 0;
            this.btnList.IconRightVisible = true;
            this.btnList.IconRightZoom = 0D;
            this.btnList.IconVisible = true;
            this.btnList.IconZoom = 50D;
            this.btnList.IsTab = true;
            this.btnList.Location = new System.Drawing.Point(0, 258);
            this.btnList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnList.Name = "btnList";
            this.btnList.Normalcolor = System.Drawing.Color.White;
            this.btnList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnList.selected = false;
            this.btnList.Size = new System.Drawing.Size(267, 59);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Danh sách";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnList.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDebt
            // 
            this.btnDebt.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnDebt.BackColor = System.Drawing.Color.White;
            this.btnDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDebt.BorderRadius = 0;
            this.btnDebt.ButtonText = "Công nợ";
            this.btnDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebt.DisabledColor = System.Drawing.Color.Gray;
            this.btnDebt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDebt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDebt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDebt.Iconimage")));
            this.btnDebt.Iconimage_right = null;
            this.btnDebt.Iconimage_right_Selected = null;
            this.btnDebt.Iconimage_Selected = null;
            this.btnDebt.IconMarginLeft = 0;
            this.btnDebt.IconMarginRight = 0;
            this.btnDebt.IconRightVisible = true;
            this.btnDebt.IconRightZoom = 0D;
            this.btnDebt.IconVisible = true;
            this.btnDebt.IconZoom = 50D;
            this.btnDebt.IsTab = true;
            this.btnDebt.Location = new System.Drawing.Point(0, 383);
            this.btnDebt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Normalcolor = System.Drawing.Color.White;
            this.btnDebt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDebt.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnDebt.selected = false;
            this.btnDebt.Size = new System.Drawing.Size(267, 59);
            this.btnDebt.TabIndex = 1;
            this.btnDebt.Text = "Công nợ";
            this.btnDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDebt.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnDebt.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 193);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.White;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(267, 59);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaff.BorderRadius = 0;
            this.btnStaff.ButtonText = "Thông tin nhân viên";
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStaff.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStaff.Iconimage")));
            this.btnStaff.Iconimage_right = null;
            this.btnStaff.Iconimage_right_Selected = null;
            this.btnStaff.Iconimage_Selected = null;
            this.btnStaff.IconMarginLeft = 0;
            this.btnStaff.IconMarginRight = 0;
            this.btnStaff.IconRightVisible = true;
            this.btnStaff.IconRightZoom = 0D;
            this.btnStaff.IconVisible = true;
            this.btnStaff.IconZoom = 50D;
            this.btnStaff.IsTab = true;
            this.btnStaff.Location = new System.Drawing.Point(0, 444);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Normalcolor = System.Drawing.Color.White;
            this.btnStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnStaff.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStaff.selected = false;
            this.btnStaff.Size = new System.Drawing.Size(267, 59);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Thông tin nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStaff.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStaff.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 183);
            this.panel3.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Silver;
            this.labelName.Location = new System.Drawing.Point(31, 112);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(177, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Trung tâm anh ngữ";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(64, 48);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(133, 62);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // nMainElipse
            // 
            this.nMainElipse.ElipseRadius = 5;
            this.nMainElipse.TargetControl = this;
            // 
            // headerDragControl
            // 
            this.headerDragControl.Fixed = true;
            this.headerDragControl.Horizontal = true;
            this.headerDragControl.TargetControl = this.header;
            this.headerDragControl.Vertical = true;
            // 
            // sideMain
            // 
            this.sideMain.Controls.Add(this.ucInfoApplication);
            this.sideMain.Controls.Add(this.ucStaff);
            this.sideMain.Controls.Add(this.ucDebt);
            this.sideMain.Controls.Add(this.ucManagement);
            this.sideMain.Controls.Add(this.ucList);
            this.sideMain.Controls.Add(this.ucHome);
            this.sideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideMain.Location = new System.Drawing.Point(267, 49);
            this.sideMain.Margin = new System.Windows.Forms.Padding(4);
            this.sideMain.Name = "sideMain";
            this.sideMain.Size = new System.Drawing.Size(804, 557);
            this.sideMain.TabIndex = 2;
            // 
            // ucInfoApplication
            // 
            this.ucInfoApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInfoApplication.Location = new System.Drawing.Point(0, 0);
            this.ucInfoApplication.Margin = new System.Windows.Forms.Padding(4);
            this.ucInfoApplication.Name = "ucInfoApplication";
            this.ucInfoApplication.Size = new System.Drawing.Size(804, 557);
            this.ucInfoApplication.TabIndex = 5;
            // 
            // ucStaff
            // 
            this.ucStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ucStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStaff.Location = new System.Drawing.Point(0, 0);
            this.ucStaff.Margin = new System.Windows.Forms.Padding(4);
            this.ucStaff.Name = "ucStaff";
            this.ucStaff.Size = new System.Drawing.Size(804, 557);
            this.ucStaff.TabIndex = 4;
            // 
            // ucDebt
            // 
            this.ucDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDebt.Location = new System.Drawing.Point(0, 0);
            this.ucDebt.Margin = new System.Windows.Forms.Padding(4);
            this.ucDebt.Name = "ucDebt";
            this.ucDebt.Size = new System.Drawing.Size(804, 557);
            this.ucDebt.TabIndex = 3;
            // 
            // ucManagement
            // 
            this.ucManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManagement.Location = new System.Drawing.Point(0, 0);
            this.ucManagement.Margin = new System.Windows.Forms.Padding(4);
            this.ucManagement.Name = "ucManagement";
            this.ucManagement.Size = new System.Drawing.Size(804, 557);
            this.ucManagement.TabIndex = 2;
            // 
            // ucList
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Margin = new System.Windows.Forms.Padding(4);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(804, 557);
            this.ucList.TabIndex = 1;
            // 
            // ucHome
            // 
            this.ucHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome.Location = new System.Drawing.Point(0, 0);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(804, 557);
            this.ucHome.TabIndex = 0;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1071, 606);
            this.Controls.Add(this.sideMain);
            this.Controls.Add(this.panelsideMenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripLogin;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nMain";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelsideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoApplication)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sideMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panelsideMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnDebt;
        private Bunifu.Framework.UI.BunifuFlatButton btnStaff;
        private Bunifu.Framework.UI.BunifuElipse nMainElipse;
        private Bunifu.Framework.UI.BunifuDragControl headerDragControl;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sideMain;
        private ucMainStaff ucMainStaff;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private ucMainManagement ucMainManagement;
        private Bunifu.Framework.UI.BunifuFlatButton btnList;
        private ucMainDebt ucMainDebt;
        private ucMainList ucMainList;
        private Bunifu.Framework.UI.BunifuImageButton btnInfoApplication;
        private ucMainInfoApplication ucMainInfoApplication;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private ucMainHome ucMainHome;
        private ucMainStaff ucStaff;
        private ucMainDebt ucDebt;
        private ucMainManagement ucManagement;
        private ucMainList ucList;
        private ucMainHome ucHome;
        private ucMainInfoApplication ucInfoApplication;
    }
}