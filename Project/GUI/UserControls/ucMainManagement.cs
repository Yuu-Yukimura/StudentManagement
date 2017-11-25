using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.UserControls
{
    public partial class ucMainManagement : UserControl
    {
        public ucMainManagement()
        {
            InitializeComponent();
            //Load thông tin
            Load();
        }

        #region Event

        #region Sinh viên
        //
        // Sinh viên
        //
        //Click vào nút xem thông tin sinh viên
        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentGUI f = new ViewStudentGUI(txbIDStudent.Text);
            f.ShowDialog();
            LoadStudent();
            AddStudentBinding();
        }

        //Click vào nút thêm sinh viên
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentGUI f = new AddStudentGUI();
            f.ShowDialog();
            LoadStudent();
            AddStudentBinding();
        }

        //Click vào nút xóa sinh viên
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa sinh viên này ko ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (StudentService.Instance.DeleteStudent(int.Parse(txbIDStudent.Text)))
                {
                    MessageBox.Show("Đã xóa thành công sinh viên", "Thông báo");
                    LoadStudent();
                    AddStudentBinding();
                }
                else
                    MessageBox.Show("xóa không thành công", "Thông báo");

            }
        }
        #endregion

        #region Nhân viên
        //
        // Nhân viên
        //
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffGUI f = new AddStaffGUI();
            f.ShowDialog();
            LoadStaff();
            AddStaffBinding();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            ViewStaffGUI f = new ViewStaffGUI(txbIDStaff.Text);
            f.ShowDialog();
            LoadStaff();
            AddStaffBinding();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa nhân viên này ko ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (StaffService.Instance.DeleteAccountAndStaff(int.Parse(txbIDStaff.Text)))
                {
                    MessageBox.Show("Đã xóa thành công nhân viên và tài khoản của nhân viên.", "Thông báo");
                    LoadStudent();
                    AddStudentBinding();
                }
                else
                    MessageBox.Show("xóa không thành công", "Thông báo");

            }
        }
        #endregion

        #region Môn
        //
        // Môn học
        //
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectGUI f = new AddSubjectGUI();
            f.ShowDialog();
            LoadSubject();
            AddSubjectBinding();
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn sửa môn học này không","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txbIDSubject.Text);
                string name = txbNameSubject.Text;
                decimal money = decimal.Parse(txbMoneySubject.Text);
                Subject subject = new Subject(id, name, money);
                if(SubjectService.Instance.EditSubjectById(subject))
                {
                    MessageBox.Show("Bạn đã sửa môn học thành công", "Thông báo", MessageBoxButtons.OK);
                    LoadSubject();
                    AddSubjectBinding();
                }
                else
                {
                    MessageBox.Show("Bạn đã sửa môn học không thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Lớp
        //
        // Lớp
        //
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassGUI f = new AddClassGUI();
            f.ShowDialog();
            LoadClass();
            AddClassBinding();
        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Method

        private void Load()
        {
            LoadStudent();
            AddStudentBinding();
            LoadStaff();
            AddStaffBinding();
            LoadSubject();
            AddSubjectBinding();
            LoadClass();
            AddClassBinding();
        }

        //Load thông tin sinh viên
        private void LoadStudent()
        {
            dtgvListStudent.DataSource = StudentService.Instance.GetStudentList();
            //Thay đổi width cho column Name
            DataGridViewColumn columnName = dtgvListStudent.Columns[1];
            columnName.Width = 300;
        }

        //Liên kết thông tin sinh viên
        private void AddStudentBinding()
        {
            txbIDStudent.DataBindings.Clear();
            txbNameStudent.DataBindings.Clear();
            pbxAvatarStudent.DataBindings.Clear();
            txbIDStudent.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "ID"));
            txbNameStudent.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "Name"));
            pbxAvatarStudent.DataBindings.Add(new Binding("Image", dtgvListStudent.DataSource, "Avatar", true));
        }

        //Load thông tin nhân viên
        private void LoadStaff()
        {
            dtgvListStaff.DataSource = StaffService.Instance.GetListStaff();
            //Thay đổi width cho column Name
            DataGridViewColumn columnName = dtgvListStaff.Columns[1];
            columnName.Width = 295;
        }

        //Liên kết thông tin nhân viên
        private void AddStaffBinding()
        {
            txbIDStaff.DataBindings.Clear();
            txbNameStaff.DataBindings.Clear();
            pbxAvatarStaff.DataBindings.Clear();
            txbIDStaff.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "ID"));
            txbNameStaff.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "Name"));
            pbxAvatarStaff.DataBindings.Add(new Binding("Image", dtgvListStaff.DataSource, "Avatar", true));
        }

        //Load thông tin subject
        private void LoadSubject()
        {
            dtgvListSubject.DataSource = SubjectService.Instance.GetListSubject();
            //Thay đổi width cho column Name
            DataGridViewColumn columnName = dtgvListSubject.Columns[1];
            columnName.Width = 295;
        }

        //Liên kết thông tin môn học
        private void AddSubjectBinding()
        {
            txbIDSubject.DataBindings.Clear();
            txbNameSubject.DataBindings.Clear();
            txbMoneySubject.DataBindings.Clear();
            txbIDSubject.DataBindings.Add(new Binding("Text", dtgvListSubject.DataSource, "ID"));
            txbNameSubject.DataBindings.Add(new Binding("Text", dtgvListSubject.DataSource, "Name"));
            txbMoneySubject.DataBindings.Add(new Binding("Text", dtgvListSubject.DataSource, "Money"));
        }

        //Load thông tin Class
        private void LoadClass()
        {
            dtgvListClass.DataSource = ClassService.Instance.GetSubjectStaffNameByClass();
            //Thay đổi width cho column Name
            DataGridViewColumn columnName = dtgvListClass.Columns[1];
            columnName.Width = 295;
        }

        //Liên kết thông tin lớp học
        private void AddClassBinding()
        {
            txbIDClass.DataBindings.Clear();
            txbNameClass.DataBindings.Clear();
            txbSubjectClass.DataBindings.Clear();
            txbStatusClass.DataBindings.Clear();
            txbStaffClass.DataBindings.Clear();
            txbIDClass.DataBindings.Add(new Binding("Text", dtgvListClass.DataSource, "Mã môn học"));
            txbNameClass.DataBindings.Add(new Binding("Text", dtgvListClass.DataSource, "Tên lớp"));
            txbSubjectClass.DataBindings.Add(new Binding("Text", dtgvListClass.DataSource, "Tên môn học"));
            txbStatusClass.DataBindings.Add(new Binding("Text", dtgvListClass.DataSource, "Status"));
            txbStaffClass.DataBindings.Add(new Binding("Text", dtgvListClass.DataSource, "Tên giảng viên"));
        }

        #endregion

    }
}
