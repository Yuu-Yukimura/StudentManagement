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
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            ucHome.BringToFront();
        }

        #region Events

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome.BringToFront();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ucList.BringToFront();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ucManagement.BringToFront();
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            ucDebt.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ucStaff.BringToFront();
        }

        private void btnInfoApplication_Click(object sender, EventArgs e)
        {
            ucInfoApplication.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
