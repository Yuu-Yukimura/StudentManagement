using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class nMain : Form
    {
        public nMain()
        {
            InitializeComponent();
            infoHome.BringToFront();
        }

        #region Events ( Sự kiện )

        #region Click

        // Click button Exit ( nhấn nút thoát )
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        // Click button Minimize ( nhấn nút thu nhỏ )
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Click button Menu ( nhấn nút menu )
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelsideMenu.Width >= 200)
            {
                logo.Location = new Point(0, 55);
                logo.Size = new Size(50, 25);
                labelName.Visible = false;
                panelsideMenu.Width = 50;
                btnInfoApplication.Location = new Point(227, 523);
            }
            else
            {
                logo.Location = new Point(48, 39);
                logo.Size = new Size(100, 50);
                labelName.Visible = true;
                panelsideMenu.Width = 267;
                btnInfoApplication.Location = new Point(227, 523);
            }
        }

        // Click button Home ( nhấn nút Home )
        private void btnHome_Click(object sender, EventArgs e)
        {
            infoHome.BringToFront();
        }

        // Click button Staff ( nhấn nút Nhân viên )
        private void btnStaff_Click(object sender, EventArgs e)
        {
            infoStaff.BringToFront();
        }

        // Click button Management ( nhấn nút Quản lý )
        private void btnManagement_Click(object sender, EventArgs e)
        {
            infoManagement.BringToFront();
        }

        // Click button Debt ( nhấn nút Công nợ )
        private void btnDebt_Click(object sender, EventArgs e)
        {
            infoDebt.BringToFront();
        }

        // Click button List ( nhấn nút Danh sách )
        private void btnList_Click(object sender, EventArgs e)
        {
            infoList.BringToFront();
        }

        // Click button InfoApplication ( nhấn nút Info )
        private void btnInfoApplication_Click(object sender, EventArgs e)
        {
            infoApplication.BringToFront();
        }

        #endregion

        #region Sự kiện liên quan đến đẳng nhập xuất

        // Click button ChangePassword ( nhấn nút Đổi mật khẩu )
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            infochangePassword.BringToFront();
        }

        // Click button Logout ( nhấn nút đẳng xuất )
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

        #region Method (Phương thức)

        #endregion


    }
}
