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
        private void btnExitViewStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào button Hủy
        private void btnCancelViewStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Click vào button -
        private void btnMinimizeViewStudent_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Click vào button Sửa
        //Sẽ lưu toàn bộ thông tin vừa chỉnh sửa vào csdl bằng id
        private void btnEditViewStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin sinh viên này không ??","Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string name = txbNameViewStudent.Text;
                byte[] avatar = Utility.ImageToByteArray(pbxAvatarViewStudent.Image);
                string address = txbAddressViewStudent.Text;
                string phone = txbPhoneViewStudent.Text;
                string parentPhone = txbParentPhoneViewStudent.Text;
                Boolean sex = ConvertSexToBoolean();
                DateTime dateOfBirth = dtpkDateOfBirthViewStudent.Value.Date;

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

        }

        //Khi Click vào ảnh sẽ hiện cửa sổ chọn ảnh
        private void pbxAvatarViewStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Lấy các file có đuôi jpg
            dialog.Filter = "JPG Files| *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                pbxAvatarViewStudent.Image = Image.FromFile(dialog.FileName);
            }
        }

        #endregion

        #region Method

        //Load thông tin sinh viên có id = id lên các controls
        private void LoadView()
        {
            Student student = StudentService.Instance.GetStudentByID(ID);
            // Tiêu đề
            lbHeadlineViewStudent.Text += student.Name;
            // Tên
            txbNameViewStudent.Text = student.Name;
            // Địa chỉ
            txbAddressViewStudent.Text = student.Address;
            // Phone
            txbPhoneViewStudent.Text = student.Phone;
            // Sdt phụ huynh
            txbParentPhoneViewStudent.Text = student.ParentPhone;
            // load ảnh bằng cách covert từ mảng byte -> ảnh
            pbxAvatarViewStudent.Image = Utility.ByteArrayToImage(student.Avatar);
            // Giới tính
            if (student.Sex)
                rdbMaleViewStudent.Checked = true;
            else
                rdbFemaleViewStudent.Checked = true;

            // Ngày sinh
            dtpkDateOfBirthViewStudent.Value = student.DateOfBirth;

        }

        //Covert từ sex sang boolean
        private Boolean ConvertSexToBoolean()
        {
            if (rdbMaleViewStudent.Checked == true)
                return true;
            return false;
        }

        #endregion


    }
}
