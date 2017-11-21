using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        #region Event

        #region Click

        // Click button Login ( nhấn nút Đẳng nhập )
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if(Login(userName, passWord))
            {
                MainGUI f = new MainGUI();
                this.Hide();
                f.ShowDialog();
                this.Show();
                txbUserName.Text = "";
                txbPassWord.Text = "";
            }
            else
            {
                MessageBox.Show("Tên đẳng nhập hoặc mật khẩu sai, xin hãy nhập lại.","Thông báo",MessageBoxButtons.OK);
            }
        }

        // Click button Exit ( nhấn nút Thoát )
        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        // Click button Minimize on toolbox ( nhấn vào nút thu nhỏ trên thanh )
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Click button Exit on toolbox ( nhấn vào nút thoát trên thanh )
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

        #endregion


        #region Method

        // Hàm xử lý đẳng nhập
        private bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }



        #endregion

    }
}
