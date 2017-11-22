using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class ViewStaffGUI : Form
    {
        int ID;

        public ViewStaffGUI(string id)
        {
            InitializeComponent();
            ID = int.Parse(id);
            LoadView();
        }

        #region Events

        //Click vào nút Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn sửa thông tin nhân viên này không ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK);
                EditView();
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

        private void LoadView()
        {
            Staff staff = StaffService.Instance.GetStaffById(ID);

            // Tiêu đề
            lbHeadline.Text += staff.Name;
            // Tên
            txbName.Text = staff.Name;
            // Địa chỉ
            txbAddress.Text = staff.Address;
            // Phone 
            txbPhone.Text = staff.Phone;
            // load ảnh bằng cách covert từ mảng byte -> ảnh
            pbxAvatar.Image = Utility.ByteArrayToImage(staff.Avatar);
            // Giới tính
            if (staff.Sex)
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
            // Tình trạng hôn nhân
            if (staff.MaritalStatus)
                rdbMarried.Checked = true;
            else
                rdbSingle.Checked = true;
            // Quyền
            if (staff.Admin)
                rdbAdmin.Checked = true;
            else
                rdbUser.Checked = true;
            // Chức vụ
            if (staff.Type)
                rdbTeacher.Checked = true;
            else
                rdbStaff.Checked = true;
            // Ngày sinh
            dtpkDateOfBirth.Value = staff.DateOfBirth;
        }

        private void EditView()
        {
            int id = ID;
            string name = txbName.Text;
            byte[] avatar = Utility.ImageToByteArray(pbxAvatar.Image);
            string address = txbAddress.Text;
            string phone = txbPhone.Text;
            Boolean sex = Utility.ConvertSexToBoolean(rdbMale);
            Boolean admin = Utility.ConvertSexToBoolean(rdbAdmin);
            Boolean maritalStatus = Utility.ConvertSexToBoolean(rdbMarried);
            Boolean type = Utility.ConvertSexToBoolean(rdbTeacher);
            DateTime dateOfBirth = dtpkDateOfBirth.Value.Date;

            Staff staff = new Staff(id, name, avatar, sex, dateOfBirth, address, phone, maritalStatus, type, admin);

            if (StaffService.Instance.EditStaffById(staff))
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sửa thông tin không thành công", "Thông báo", MessageBoxButtons.OK);

        }

        #endregion
    }
}
