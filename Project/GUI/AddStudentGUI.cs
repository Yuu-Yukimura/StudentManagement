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
    public partial class AddStudentGUI : Form
    {
        public AddStudentGUI()
        {
            InitializeComponent();
        }

        #region Events

        // Click vào button Thêm
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Gọi hàm insert
            InsertStudent();
        }

        // Click vào button Thoát
        private void btnExitAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click vào button -
        private void btnMinimizeAddStudent_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Click vào button Hủy
        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click vào ảnh để hiện cửa sổ
        private void pbxAvatarViewStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //Lấy các file có đuôi jpg
            dialog.Filter = "JPG Files| *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxAvatarViewStudent.Image = Image.FromFile(dialog.FileName);
            }
        }

        #endregion

        #region Method

        // Hàm thêm sinh viên 
        private void InsertStudent()
        {
            //Ktra có text có rỗng hay ko ??
            if (Utility.CheckTextBoxEmpty(txbNameAddStudent) && Utility.CheckTextBoxEmpty(txbAddressAddStudent) && Utility.CheckTextBoxEmpty(txbPhoneAddStudent) && Utility.CheckTextBoxEmpty(txbParentPhoneAddStudent))
            {
                // Xác nhận
                if (MessageBox.Show("Bạn có muốn thêm sinh viên này không ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string name = txbNameAddStudent.Text;
                    byte[] avatar = Utility.ImageToByteArray(pbxAvatarViewStudent.Image);
                    string address = txbAddressAddStudent.Text;
                    string phone = txbPhoneAddStudent.Text;
                    string parentPhone = txbParentPhoneAddStudent.Text;
                    Boolean sex = Utility.ConvertSexToBoolean(rdbMaleAddStudent);
                    DateTime dateOfBirth = dtpkDateOfBirthAddStudent.Value.Date;

                    Student student = new Student(name, avatar, sex, dateOfBirth, address, phone, parentPhone);

                    if (StudentService.Instance.AddStudent(student))
                    {
                        MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sinh viên không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
                MessageBox.Show("Xin hãy điền đầy đủ thông tin.", "Thông báo");

        }
        #endregion

    }
}
