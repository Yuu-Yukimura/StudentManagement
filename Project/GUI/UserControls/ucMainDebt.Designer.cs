namespace GUI.UserControls
{
    partial class ucMainDebt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMainDebt));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbIDDebt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListDebt = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNameStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSumOfDebt = new System.Windows.Forms.TextBox();
            this.pbxAvatarStudent = new System.Windows.Forms.PictureBox();
            this.btnViewDebt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dtgvListDebt);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(796, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Công nợ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewDebt);
            this.panel1.Controls.Add(this.pbxAvatarStudent);
            this.panel1.Controls.Add(this.txbSumOfDebt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbNameStudent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbIDStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbIDDebt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(472, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 504);
            this.panel1.TabIndex = 1;
            // 
            // txbIDDebt
            // 
            this.txbIDDebt.Location = new System.Drawing.Point(130, 270);
            this.txbIDDebt.Name = "txbIDDebt";
            this.txbIDDebt.ReadOnly = true;
            this.txbIDDebt.Size = new System.Drawing.Size(184, 34);
            this.txbIDDebt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nợ :";
            // 
            // dtgvListDebt
            // 
            this.dtgvListDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListDebt.Location = new System.Drawing.Point(7, 7);
            this.dtgvListDebt.Name = "dtgvListDebt";
            this.dtgvListDebt.RowTemplate.Height = 24;
            this.dtgvListDebt.Size = new System.Drawing.Size(459, 508);
            this.dtgvListDebt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(796, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thành tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên :";
            // 
            // txbIDStudent
            // 
            this.txbIDStudent.Location = new System.Drawing.Point(130, 310);
            this.txbIDStudent.Name = "txbIDStudent";
            this.txbIDStudent.ReadOnly = true;
            this.txbIDStudent.Size = new System.Drawing.Size(184, 34);
            this.txbIDStudent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên :";
            // 
            // txbNameStudent
            // 
            this.txbNameStudent.Location = new System.Drawing.Point(130, 350);
            this.txbNameStudent.Name = "txbNameStudent";
            this.txbNameStudent.ReadOnly = true;
            this.txbNameStudent.Size = new System.Drawing.Size(184, 34);
            this.txbNameStudent.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng nợ :";
            // 
            // txbSumOfDebt
            // 
            this.txbSumOfDebt.Location = new System.Drawing.Point(130, 390);
            this.txbSumOfDebt.Name = "txbSumOfDebt";
            this.txbSumOfDebt.ReadOnly = true;
            this.txbSumOfDebt.Size = new System.Drawing.Size(184, 34);
            this.txbSumOfDebt.TabIndex = 2;
            // 
            // pbxAvatarStudent
            // 
            this.pbxAvatarStudent.Image = ((System.Drawing.Image)(resources.GetObject("pbxAvatarStudent.Image")));
            this.pbxAvatarStudent.Location = new System.Drawing.Point(69, 29);
            this.pbxAvatarStudent.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAvatarStudent.Name = "pbxAvatarStudent";
            this.pbxAvatarStudent.Size = new System.Drawing.Size(179, 202);
            this.pbxAvatarStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatarStudent.TabIndex = 31;
            this.pbxAvatarStudent.TabStop = false;
            // 
            // btnViewDebt
            // 
            this.btnViewDebt.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnViewDebt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewDebt.BorderRadius = 0;
            this.btnViewDebt.ButtonText = "Xem";
            this.btnViewDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDebt.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewDebt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnViewDebt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewDebt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewDebt.Iconimage")));
            this.btnViewDebt.Iconimage_right = null;
            this.btnViewDebt.Iconimage_right_Selected = null;
            this.btnViewDebt.Iconimage_Selected = null;
            this.btnViewDebt.IconMarginLeft = 0;
            this.btnViewDebt.IconMarginRight = 0;
            this.btnViewDebt.IconRightVisible = true;
            this.btnViewDebt.IconRightZoom = 0D;
            this.btnViewDebt.IconVisible = true;
            this.btnViewDebt.IconZoom = 50D;
            this.btnViewDebt.IsTab = true;
            this.btnViewDebt.Location = new System.Drawing.Point(5, 439);
            this.btnViewDebt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewDebt.Name = "btnViewDebt";
            this.btnViewDebt.Normalcolor = System.Drawing.Color.White;
            this.btnViewDebt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnViewDebt.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnViewDebt.selected = true;
            this.btnViewDebt.Size = new System.Drawing.Size(307, 59);
            this.btnViewDebt.TabIndex = 32;
            this.btnViewDebt.Text = "Xem";
            this.btnViewDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDebt.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnViewDebt.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDebt.Click += new System.EventHandler(this.btnViewDebt_Click);
            // 
            // ucMainDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMainDebt";
            this.Size = new System.Drawing.Size(804, 556);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvListDebt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbIDDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSumOfDebt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNameStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIDStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxAvatarStudent;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewDebt;
    }
}
