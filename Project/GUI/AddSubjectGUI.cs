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
    public partial class AddSubjectGUI : Form
    {
        public AddSubjectGUI()
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubject();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods
        
        private void AddSubject()
        {
            
            if (Utility.CheckTextBoxEmpty(txbName) && Utility.CheckTextBoxEmpty(txbMoney))
                if(Utility.CheckNumberTextBox(txbMoney))
                {
                    if(SubjectService.Instance.CheckNameSubject(txbName.Text))
                        if (MessageBox.Show("Bạn có muốn thêm môn học này ko ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            string name = txbName.Text;
                            decimal money = decimal.Parse(txbMoney.Text);
                            Subject subject = new Subject(name, money);
                            if (SubjectService.Instance.AddSubject(subject))
                            {
                                MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Thêm môn học không thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else { }
                    else
                    {
                        MessageBox.Show("Tên môn học bị trùng !!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đúng !!","Thông báo",MessageBoxButtons.OK);
                }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        #endregion

    }
}
