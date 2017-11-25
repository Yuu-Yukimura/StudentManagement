using BUS;
using DTO;
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
    public partial class AddAccountGUI : Form
    {
        Staff staff = new Staff();
        public AddAccountGUI(Staff staff)
        {
            this.staff = staff;
            InitializeComponent();
        }

        #region Events

        private void btnExitView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeView_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void Check()
        {            
            if(Utility.CheckTextBoxEmpty(txbUserName) && Utility.CheckTextBoxEmpty(txbPassWord) && Utility.CheckTextBoxEmpty(txbRePassWord))
            {
                if(MessageBox.Show("Bạn có muốn hoàn tất không ?, tên đẳng nhập sẽ không bao giờ được đổi.", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (txbPassWord.Text == txbRePassWord.Text)
                    {
                        Account account = new Account(txbUserName.Text, txbPassWord.Text);
                        if(AccountService.Instance.CheckUserNameIsOnly(account.UserName))
                        {
                            if (StaffService.Instance.AddStaff(staff))
                            {
                                if (AccountService.Instance.AddAccount(account))
                                {
                                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Trùng tên đẳng nhập, xin hãy nhập lại.", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập thông tin nhân viên sai xin hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Trùng tên đẳng nhập, xin hãy nhập lại.", "Thông báo", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập toàn bộ nôi dung", "Thông báo", MessageBoxButtons.OK);
            }
        }

        #endregion

    }
}
