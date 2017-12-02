namespace GUI
{
    partial class ClassCancelGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassCancelGUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerViewStudent = new System.Windows.Forms.Panel();
            this.btnExitView = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizeView = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbHeadline = new System.Windows.Forms.Label();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClassCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtgvListStudent = new System.Windows.Forms.DataGridView();
            this.txbSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtgvListClassStudentRegistration = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchClassStudentRegistration = new System.Windows.Forms.TextBox();
            this.btnSearchClass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).BeginInit();
            this.menuStripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListClassStudentRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // headerViewStudent
            // 
            this.headerViewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.headerViewStudent.Controls.Add(this.btnExitView);
            this.headerViewStudent.Controls.Add(this.btnMinimizeView);
            this.headerViewStudent.Controls.Add(this.lbHeadline);
            this.headerViewStudent.Controls.Add(this.menuStripLogin);
            this.headerViewStudent.Controls.Add(this.btnMinimize);
            this.headerViewStudent.Controls.Add(this.btnExit);
            this.headerViewStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerViewStudent.Location = new System.Drawing.Point(0, 0);
            this.headerViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.headerViewStudent.Name = "headerViewStudent";
            this.headerViewStudent.Size = new System.Drawing.Size(804, 49);
            this.headerViewStudent.TabIndex = 1;
            // 
            // btnExitView
            // 
            this.btnExitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnExitView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitView.Image = ((System.Drawing.Image)(resources.GetObject("btnExitView.Image")));
            this.btnExitView.ImageActive = null;
            this.btnExitView.Location = new System.Drawing.Point(764, 13);
            this.btnExitView.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitView.Name = "btnExitView";
            this.btnExitView.Size = new System.Drawing.Size(27, 25);
            this.btnExitView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitView.TabIndex = 5;
            this.btnExitView.TabStop = false;
            this.btnExitView.Zoom = 20;
            this.btnExitView.Click += new System.EventHandler(this.btnExitView_Click);
            // 
            // btnMinimizeView
            // 
            this.btnMinimizeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnMinimizeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeView.Image")));
            this.btnMinimizeView.ImageActive = null;
            this.btnMinimizeView.Location = new System.Drawing.Point(729, 12);
            this.btnMinimizeView.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizeView.Name = "btnMinimizeView";
            this.btnMinimizeView.Size = new System.Drawing.Size(27, 25);
            this.btnMinimizeView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeView.TabIndex = 4;
            this.btnMinimizeView.TabStop = false;
            this.btnMinimizeView.Zoom = 20;
            this.btnMinimizeView.Click += new System.EventHandler(this.btnMinimizeView_Click);
            // 
            // lbHeadline
            // 
            this.lbHeadline.AutoSize = true;
            this.lbHeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeadline.ForeColor = System.Drawing.Color.Silver;
            this.lbHeadline.Location = new System.Drawing.Point(13, 9);
            this.lbHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeadline.Name = "lbHeadline";
            this.lbHeadline.Size = new System.Drawing.Size(171, 28);
            this.lbHeadline.TabIndex = 2;
            this.lbHeadline.Text = "Đăng ký môn học ";
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
            this.menuStripLogin.Location = new System.Drawing.Point(875, 7);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripLogin.Size = new System.Drawing.Size(81, 36);
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
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerViewStudent;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnClassCancel);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 81);
            this.panel2.TabIndex = 32;
            // 
            // btnClassCancel
            // 
            this.btnClassCancel.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnClassCancel.BackColor = System.Drawing.Color.Silver;
            this.btnClassCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClassCancel.BorderRadius = 0;
            this.btnClassCancel.ButtonText = "Hủy lớp";
            this.btnClassCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnClassCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClassCancel.Iconimage = null;
            this.btnClassCancel.Iconimage_right = null;
            this.btnClassCancel.Iconimage_right_Selected = null;
            this.btnClassCancel.Iconimage_Selected = null;
            this.btnClassCancel.IconMarginLeft = 0;
            this.btnClassCancel.IconMarginRight = 0;
            this.btnClassCancel.IconRightVisible = true;
            this.btnClassCancel.IconRightZoom = 0D;
            this.btnClassCancel.IconVisible = true;
            this.btnClassCancel.IconZoom = 50D;
            this.btnClassCancel.IsTab = false;
            this.btnClassCancel.Location = new System.Drawing.Point(480, 17);
            this.btnClassCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnClassCancel.Name = "btnClassCancel";
            this.btnClassCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btnClassCancel.OnHovercolor = System.Drawing.Color.Empty;
            this.btnClassCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnClassCancel.selected = false;
            this.btnClassCancel.Size = new System.Drawing.Size(150, 50);
            this.btnClassCancel.TabIndex = 22;
            this.btnClassCancel.Text = "Hủy lớp";
            this.btnClassCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClassCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnClassCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassCancel.Click += new System.EventHandler(this.btnClassCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.BorderRadius = 0;
            this.btnNext.ButtonText = "Tiếp theo";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledColor = System.Drawing.Color.Gray;
            this.btnNext.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNext.Iconimage = null;
            this.btnNext.Iconimage_right = null;
            this.btnNext.Iconimage_right_Selected = null;
            this.btnNext.Iconimage_Selected = null;
            this.btnNext.IconMarginLeft = 0;
            this.btnNext.IconMarginRight = 0;
            this.btnNext.IconRightVisible = true;
            this.btnNext.IconRightZoom = 0D;
            this.btnNext.IconVisible = true;
            this.btnNext.IconZoom = 50D;
            this.btnNext.IsTab = false;
            this.btnNext.Location = new System.Drawing.Point(960, 27);
            this.btnNext.Margin = new System.Windows.Forms.Padding(8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Normalcolor = System.Drawing.Color.Silver;
            this.btnNext.OnHovercolor = System.Drawing.Color.Empty;
            this.btnNext.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnNext.selected = false;
            this.btnNext.Size = new System.Drawing.Size(225, 78);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnNext.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtgvListStudent
            // 
            this.dtgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListStudent.Location = new System.Drawing.Point(12, 137);
            this.dtgvListStudent.Name = "dtgvListStudent";
            this.dtgvListStudent.ReadOnly = true;
            this.dtgvListStudent.RowTemplate.Height = 24;
            this.dtgvListStudent.Size = new System.Drawing.Size(381, 333);
            this.dtgvListStudent.TabIndex = 33;
            this.dtgvListStudent.SelectionChanged += new System.EventHandler(this.dtgvListStudent_SelectionChanged);
            // 
            // txbSearchStudent
            // 
            this.txbSearchStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchStudent.Location = new System.Drawing.Point(12, 96);
            this.txbSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchStudent.Name = "txbSearchStudent";
            this.txbSearchStudent.Size = new System.Drawing.Size(275, 34);
            this.txbSearchStudent.TabIndex = 34;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnSearchStudent.BackColor = System.Drawing.Color.Silver;
            this.btnSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchStudent.BorderRadius = 0;
            this.btnSearchStudent.ButtonText = "Tìm";
            this.btnSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStudent.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchStudent.Iconimage = null;
            this.btnSearchStudent.Iconimage_right = null;
            this.btnSearchStudent.Iconimage_right_Selected = null;
            this.btnSearchStudent.Iconimage_Selected = null;
            this.btnSearchStudent.IconMarginLeft = 0;
            this.btnSearchStudent.IconMarginRight = 0;
            this.btnSearchStudent.IconRightVisible = true;
            this.btnSearchStudent.IconRightZoom = 0D;
            this.btnSearchStudent.IconVisible = true;
            this.btnSearchStudent.IconZoom = 50D;
            this.btnSearchStudent.IsTab = false;
            this.btnSearchStudent.Location = new System.Drawing.Point(296, 96);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Normalcolor = System.Drawing.Color.Silver;
            this.btnSearchStudent.OnHovercolor = System.Drawing.Color.Empty;
            this.btnSearchStudent.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSearchStudent.selected = false;
            this.btnSearchStudent.Size = new System.Drawing.Size(97, 34);
            this.btnSearchStudent.TabIndex = 35;
            this.btnSearchStudent.Text = "Tìm";
            this.btnSearchStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchStudent.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSearchStudent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtgvListClassStudentRegistration
            // 
            this.dtgvListClassStudentRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListClassStudentRegistration.Location = new System.Drawing.Point(411, 137);
            this.dtgvListClassStudentRegistration.Name = "dtgvListClassStudentRegistration";
            this.dtgvListClassStudentRegistration.ReadOnly = true;
            this.dtgvListClassStudentRegistration.RowTemplate.Height = 24;
            this.dtgvListClassStudentRegistration.Size = new System.Drawing.Size(381, 333);
            this.dtgvListClassStudentRegistration.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Danh sách lớp học sinh viên đăng ký";
            // 
            // txbSearchClassStudentRegistration
            // 
            this.txbSearchClassStudentRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchClassStudentRegistration.Location = new System.Drawing.Point(411, 95);
            this.txbSearchClassStudentRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchClassStudentRegistration.Name = "txbSearchClassStudentRegistration";
            this.txbSearchClassStudentRegistration.Size = new System.Drawing.Size(275, 34);
            this.txbSearchClassStudentRegistration.TabIndex = 34;
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnSearchClass.BackColor = System.Drawing.Color.Silver;
            this.btnSearchClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchClass.BorderRadius = 0;
            this.btnSearchClass.ButtonText = "Tìm";
            this.btnSearchClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClass.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchClass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchClass.Iconimage = null;
            this.btnSearchClass.Iconimage_right = null;
            this.btnSearchClass.Iconimage_right_Selected = null;
            this.btnSearchClass.Iconimage_Selected = null;
            this.btnSearchClass.IconMarginLeft = 0;
            this.btnSearchClass.IconMarginRight = 0;
            this.btnSearchClass.IconRightVisible = true;
            this.btnSearchClass.IconRightZoom = 0D;
            this.btnSearchClass.IconVisible = true;
            this.btnSearchClass.IconZoom = 50D;
            this.btnSearchClass.IsTab = false;
            this.btnSearchClass.Location = new System.Drawing.Point(695, 95);
            this.btnSearchClass.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Normalcolor = System.Drawing.Color.Silver;
            this.btnSearchClass.OnHovercolor = System.Drawing.Color.Empty;
            this.btnSearchClass.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSearchClass.selected = false;
            this.btnSearchClass.Size = new System.Drawing.Size(97, 34);
            this.btnSearchClass.TabIndex = 35;
            this.btnSearchClass.Text = "Tìm";
            this.btnSearchClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchClass.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSearchClass.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy ";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(640, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Empty;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ClassCancelGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchClass);
            this.Controls.Add(this.txbSearchClassStudentRegistration);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txbSearchStudent);
            this.Controls.Add(this.dtgvListClassStudentRegistration);
            this.Controls.Add(this.dtgvListStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headerViewStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassCancelGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fViewStudent";
            this.headerViewStudent.ResumeLayout(false);
            this.headerViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).EndInit();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListClassStudentRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerViewStudent;
        private System.Windows.Forms.Label lbHeadline;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeView;
        private Bunifu.Framework.UI.BunifuImageButton btnExitView;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dtgvListStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSearchStudent;
        private Bunifu.Framework.UI.BunifuFlatButton btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchStudent;
        private System.Windows.Forms.DataGridView dtgvListClassStudentRegistration;
        private Bunifu.Framework.UI.BunifuFlatButton btnClassCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchClass;
        private System.Windows.Forms.TextBox txbSearchClassStudentRegistration;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}