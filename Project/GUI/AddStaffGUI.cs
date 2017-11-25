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
    public partial class AddStaffGUI : Form
    {
        public AddStaffGUI()
        {
            InitializeComponent();
        }

        #region Events

        //Click vào nút Tiếp theo
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(Utility.CheckTextBoxEmpty(txbName) && Utility.CheckTextBoxEmpty(txbAddress) && Utility.CheckTextBoxEmpty(txbPhone))
            {
                AddAccountGUI f = new AddAccountGUI(CrateAllCtrToStaff());
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập toàn bộ nôi dung", "Thông báo", MessageBoxButtons.OK);
            }         
        }

        //Click vào nút Hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào nút -
        private void btnMinimizeView_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Click vào nút x
        private void btnExitView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào ảnh
        private void pbxAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Lấy các file có đuôi jpg
            dialog.Filter = "JPG Files| *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxAvatar.Image = Image.FromFile(dialog.FileName);
            }
        }

        #endregion

        #region Methods

        private Staff CrateAllCtrToStaff()
        {
            Staff staff = new Staff();

            staff.Name = txbName.Text;
            staff.Avatar = Utility.ImageToByteArray(pbxAvatar.Image);
            staff.Sex = Utility.ConvertSexToBoolean(rdbMale);
            staff.DateOfBirth = dtpkDateOfBirth.Value;
            staff.Address = txbAddress.Text;
            staff.Phone = txbPhone.Text;
            staff.MaritalStatus = Utility.ConvertSexToBoolean(rdbMarried);
            staff.Type = Utility.ConvertSexToBoolean(rdbTeacher);
            staff.Admin = Utility.ConvertSexToBoolean(rdbAdmin);

            return staff;
        }

        #endregion



    }
}
