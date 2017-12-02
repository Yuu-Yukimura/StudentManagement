namespace GUI
{
    partial class ViewDebtInfoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDebtInfoGUI));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxAvatarStudent = new System.Windows.Forms.PictureBox();
            this.txbSumOfDebt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNameStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIDStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDDebt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListDebt = new System.Windows.Forms.DataGridView();
            this.headerViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).BeginInit();
            this.menuStripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDebt)).BeginInit();
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
            this.lbHeadline.Size = new System.Drawing.Size(254, 28);
            this.lbHeadline.TabIndex = 2;
            this.lbHeadline.Text = "Thông tin công nợ sinh viên";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pbxAvatarStudent);
            this.panel1.Controls.Add(this.txbSumOfDebt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbNameStudent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbIDStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbIDDebt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(487, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 508);
            this.panel1.TabIndex = 3;
            // 
            // pbxAvatarStudent
            // 
            this.pbxAvatarStudent.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatarStudent.Image")));
            this.pbxAvatarStudent.Location = new System.Drawing.Point(62, 29);
            this.pbxAvatarStudent.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAvatarStudent.Name = "pbxAvatarStudent";
            this.pbxAvatarStudent.Size = new System.Drawing.Size(186, 202);
            this.pbxAvatarStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatarStudent.TabIndex = 31;
            this.pbxAvatarStudent.TabStop = false;
            // 
            // txbSumOfDebt
            // 
            this.txbSumOfDebt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSumOfDebt.Location = new System.Drawing.Point(130, 390);
            this.txbSumOfDebt.Name = "txbSumOfDebt";
            this.txbSumOfDebt.ReadOnly = true;
            this.txbSumOfDebt.Size = new System.Drawing.Size(184, 34);
            this.txbSumOfDebt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng nợ :";
            // 
            // txbNameStudent
            // 
            this.txbNameStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameStudent.Location = new System.Drawing.Point(130, 350);
            this.txbNameStudent.Name = "txbNameStudent";
            this.txbNameStudent.ReadOnly = true;
            this.txbNameStudent.Size = new System.Drawing.Size(184, 34);
            this.txbNameStudent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên :";
            // 
            // txbIDStudent
            // 
            this.txbIDStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDStudent.Location = new System.Drawing.Point(130, 310);
            this.txbIDStudent.Name = "txbIDStudent";
            this.txbIDStudent.ReadOnly = true;
            this.txbIDStudent.Size = new System.Drawing.Size(184, 34);
            this.txbIDStudent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên :";
            // 
            // txbIDDebt
            // 
            this.txbIDDebt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDDebt.Location = new System.Drawing.Point(130, 270);
            this.txbIDDebt.Name = "txbIDDebt";
            this.txbIDDebt.ReadOnly = true;
            this.txbIDDebt.Size = new System.Drawing.Size(184, 34);
            this.txbIDDebt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nợ :";
            // 
            // dtgvListDebt
            // 
            this.dtgvListDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListDebt.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvListDebt.Location = new System.Drawing.Point(0, 49);
            this.dtgvListDebt.Name = "dtgvListDebt";
            this.dtgvListDebt.RowTemplate.Height = 24;
            this.dtgvListDebt.Size = new System.Drawing.Size(481, 508);
            this.dtgvListDebt.TabIndex = 2;
            this.dtgvListDebt.SelectionChanged += new System.EventHandler(this.dtgvListDebt_SelectionChanged);
            // 
            // ViewDebtInfoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvListDebt);
            this.Controls.Add(this.headerViewStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDebtInfoGUI";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDebt)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxAvatarStudent;
        private System.Windows.Forms.TextBox txbSumOfDebt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNameStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIDDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvListDebt;
    }
}