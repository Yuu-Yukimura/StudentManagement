namespace GUI
{
    partial class AddClassGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassGUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerAddClass = new System.Windows.Forms.Panel();
            this.btnExitView = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizeView = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbHeadline = new System.Windows.Forms.Label();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpkDateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpkDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.headerAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // headerAddClass
            // 
            this.headerAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.headerAddClass.Controls.Add(this.btnExitView);
            this.headerAddClass.Controls.Add(this.btnMinimizeView);
            this.headerAddClass.Controls.Add(this.lbHeadline);
            this.headerAddClass.Controls.Add(this.menuStripLogin);
            this.headerAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerAddClass.Location = new System.Drawing.Point(0, 0);
            this.headerAddClass.Margin = new System.Windows.Forms.Padding(4);
            this.headerAddClass.Name = "headerAddClass";
            this.headerAddClass.Size = new System.Drawing.Size(500, 49);
            this.headerAddClass.TabIndex = 2;
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
            this.lbHeadline.Size = new System.Drawing.Size(131, 28);
            this.lbHeadline.TabIndex = 2;
            this.lbHeadline.Text = "Thêm lớp học";
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
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 81);
            this.panel2.TabIndex = 33;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(177, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Silver;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Empty;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
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
            this.btnCancel.Location = new System.Drawing.Point(337, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Empty;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 45);
            this.panel1.TabIndex = 34;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbName.Location = new System.Drawing.Point(190, 7);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(282, 34);
            this.txbName.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(30, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên lớp học :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSubject);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 45);
            this.panel3.TabIndex = 34;
            // 
            // cbSubject
            // 
            this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(190, 7);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(282, 33);
            this.cbSubject.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Môn :";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerAddClass;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbStaff);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 45);
            this.panel4.TabIndex = 34;
            // 
            // cbStaff
            // 
            this.cbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(190, 7);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(282, 33);
            this.cbStaff.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Giảng viên :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpkDateStart);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(12, 209);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(476, 45);
            this.panel6.TabIndex = 34;
            // 
            // dtpkDateStart
            // 
            this.dtpkDateStart.CustomFormat = "";
            this.dtpkDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateStart.Location = new System.Drawing.Point(190, 5);
            this.dtpkDateStart.Name = "dtpkDateStart";
            this.dtpkDateStart.Size = new System.Drawing.Size(282, 30);
            this.dtpkDateStart.TabIndex = 32;
            this.dtpkDateStart.ValueChanged += new System.EventHandler(this.dtpkDateStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày bắt đầu :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkDateEnd);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(12, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(476, 45);
            this.panel7.TabIndex = 34;
            // 
            // dtpkDateEnd
            // 
            this.dtpkDateEnd.CustomFormat = "";
            this.dtpkDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDateEnd.Location = new System.Drawing.Point(190, 5);
            this.dtpkDateEnd.Name = "dtpkDateEnd";
            this.dtpkDateEnd.Size = new System.Drawing.Size(282, 30);
            this.dtpkDateEnd.TabIndex = 32;
            this.dtpkDateEnd.ValueChanged += new System.EventHandler(this.dtpkDateEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày kết thúc :";
            // 
            // AddClassGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headerAddClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClassGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccountGUI";
            this.headerAddClass.ResumeLayout(false);
            this.headerAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerAddClass;
        private Bunifu.Framework.UI.BunifuImageButton btnExitView;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeView;
        private System.Windows.Forms.Label lbHeadline;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDateEnd;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.DateTimePicker dtpkDateStart;
        private System.Windows.Forms.ComboBox cbStaff;
    }
}