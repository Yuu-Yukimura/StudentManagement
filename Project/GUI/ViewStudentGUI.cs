using System;
using DAO;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class ViewStudentGUI : Form
    {
        int ID;
        public ViewStudentGUI(string id)
        {
            InitializeComponent();
            // Gán ID bằng id mà form nManagement truyền qua khi click button Xem
            ID = int.Parse(id);

            // Load thông tin sinh viên bằng id
            LoadView();
        }

        #region Events
        //Click vào button X
        private void btnExitView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào button Hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào button -
        private void btnMinimizeView_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Click vào nút Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin sinh viên này không ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                EditView();
        }

        //Khi Click vào ảnh sẽ hiện cửa sổ chọn ảnh
        private void pbxAvatarViewStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Lấy các file có đuôi jpg
            dialog.Filter = "JPG Files| *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                pbxAvatar.Image = Image.FromFile(dialog.FileName);
            }
        }

        #endregion

        #region Methods

        //Hàm edit student
        private void EditView()
        {
            string name = txbName.Text;
            byte[] avatar = Utility.ImageToByteArray(pbxAvatar.Image);
            string address = txbAddress.Text;
            string phone = txbPhone.Text;
            string parentPhone = txbParentPhone.Text;
            Boolean sex = ConvertSexToBoolean();
            DateTime dateOfBirth = dtpkDateOfBirth.Value.Date;

            Student student = new Student(ID, name, avatar, sex, dateOfBirth, address, phone, parentPhone);

            if (StudentService.Instance.EditStudentByID(student))
            {
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        //Load thông tin sinh viên có id = id lên các controls
        private void LoadView()
        {
            Student student = StudentService.Instance.GetStudentByID(ID);
            // Tiêu đề
            lbHeadline.Text += student.Name;
            // Tên
            txbName.Text = student.Name;
            // Địa chỉ
            txbAddress.Text = student.Address;
            // Phone
            txbPhone.Text = student.Phone;
            // Sdt phụ huynh
            txbParentPhone.Text = student.ParentPhone;
            // load ảnh bằng cách covert từ mảng byte -> ảnh
            pbxAvatar.Image = Utility.ByteArrayToImage(student.Avatar);
            // Giới tính
            if (student.Sex)
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;

            // Ngày sinh
            dtpkDateOfBirth.Value = student.DateOfBirth;

        }

        //Covert từ sex sang boolean
        private Boolean ConvertSexToBoolean()
        {
            if (rdbMale.Checked == true)
                return true;
            return false;
        }





        #endregion

    }
}
