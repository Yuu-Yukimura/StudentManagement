namespace GUI
{
    partial class AddAccountGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountGUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerAddAccount = new System.Windows.Forms.Panel();
            this.btnExitView = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizeView = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbHeadline = new System.Windows.Forms.Label();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbRePassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerAddAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // headerAddAccount
            // 
            this.headerAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.headerAddAccount.Controls.Add(this.btnExitView);
            this.headerAddAccount.Controls.Add(this.btnMinimizeView);
            this.headerAddAccount.Controls.Add(this.lbHeadline);
            this.headerAddAccount.Controls.Add(this.menuStripLogin);
            this.headerAddAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerAddAccount.Location = new System.Drawing.Point(0, 0);
            this.headerAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.headerAddAccount.Name = "headerAddAccount";
            this.headerAddAccount.Size = new System.Drawing.Size(500, 49);
            this.headerAddAccount.TabIndex = 2;
            // 
            // btnExitView
            // 
            this.btnExitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.btnExitView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitView.Image = ((System.Drawing.Image)(resources.GetObject("btnExitView.Image")));
            this.btnExitView.ImageActive = null;
            this.btnExitView.Location = new System.Drawing.Point(460, 13);
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
            this.btnMinimizeView.Location = new System.Drawing.Point(425, 12);
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
            this.lbHeadline.Size = new System.Drawing.Size(183, 28);
            this.lbHeadline.TabIndex = 2;
            this.lbHeadline.Text = "Tài khoản nhân viên";
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStripLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLogin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStripLogin.Location = new System.Drawing.Point(875, 7);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripLogin.Size = new System.Drawing.Size(8, 4);
            this.menuStripLogin.TabIndex = 3;
            this.menuStripLogin.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 81);
            this.panel2.TabIndex = 33;
            // 
            // btnFinish
            // 
            this.btnFinish.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.BorderRadius = 0;
            this.btnFinish.ButtonText = "Hoàn tất";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinish.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinish.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFinish.Iconimage")));
            this.btnFinish.Iconimage_right = null;
            this.btnFinish.Iconimage_right_Selected = null;
            this.btnFinish.Iconimage_Selected = null;
            this.btnFinish.IconMarginLeft = 0;
            this.btnFinish.IconMarginRight = 0;
            this.btnFinish.IconRightVisible = true;
            this.btnFinish.IconRightZoom = 0D;
            this.btnFinish.IconVisible = true;
            this.btnFinish.IconZoom = 50D;
            this.btnFinish.IsTab = false;
            this.btnFinish.Location = new System.Drawing.Point(177, 17);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Normalcolor = System.Drawing.Color.Silver;
            this.btnFinish.OnHovercolor = System.Drawing.Color.Empty;
            this.btnFinish.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnFinish.selected = false;
            this.btnFinish.Size = new System.Drawing.Size(150, 50);
            this.btnFinish.TabIndex = 21;
            this.btnFinish.Text = "Hoàn tất";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnFinish.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Quay lại";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 50D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(337, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Silver;
            this.btnBack.OnHovercolor = System.Drawing.Color.Empty;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(150, 50);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 45);
            this.panel1.TabIndex = 34;
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.Location = new System.Drawing.Point(190, 4);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(282, 34);
            this.txbUserName.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(46, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên tài khoản :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 45);
            this.panel3.TabIndex = 34;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassWord.Location = new System.Drawing.Point(190, 4);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(282, 34);
            this.txbPassWord.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(79, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mật khẩu :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbRePassWord);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 45);
            this.panel4.TabIndex = 34;
            // 
            // txbRePassWord
            // 
            this.txbRePassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbRePassWord.Location = new System.Drawing.Point(190, 4);
            this.txbRePassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txbRePassWord.Name = "txbRePassWord";
            this.txbRePassWord.PasswordChar = '*';
            this.txbRePassWord.Size = new System.Drawing.Size(282, 34);
            this.txbRePassWord.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nhập lại mật khẩu :";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerAddAccount;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddAccountGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headerAddAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccountGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccountGUI";
            this.headerAddAccount.ResumeLayout(false);
            this.headerAddAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerAddAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnExitView;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeView;
        private System.Windows.Forms.Label lbHeadline;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinish;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbRePassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}