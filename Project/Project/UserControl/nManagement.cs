using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAO;
using Project.DTO;
using Project.UserCtlNew;

namespace Project
{
    public partial class nManagement : UserControl
    {
        public nManagement()
        {
            InitializeComponent();

            //Load thông tin
            Load();

        }


        #region Event

        //Click vào nút xem thông tin sinh viên
        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            fViewStudent f = new fViewStudent(txbIDStudent.Text);
            f.ShowDialog();
            LoadStudent();
        }

        #endregion

        #region Method

        private void Load()
        {
            LoadStudent();
            AddStudentBinding();
            LoadStaff();
            AddStaffBinding();
        }

        //Load thông tin sinh viên
        private void LoadStudent()
        {
            dtgvListStudent.DataSource = StudentDAO.Instance.Load_ID_Name_Avatar_Student();
            //Thay đổi width cho column Name
            DataGridViewColumn columnName = dtgvListStudent.Columns[1];
            columnName.Width = 300;
        }

        //Liên kết thông tin sinh viên
        private void AddStudentBinding()
        {           
            txbIDStudent.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "ID"));
            txbNameStudent.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "Name"));
            pbxAvatarStudent.DataBindings.Add(new Binding("Image", dtgvListStudent.DataSource, "Avatar", true));
        }

        //Load thông tin nhân viên
        private void LoadStaff()
        {
            dtgvListStaff.DataSource = StaffDAO.Instance.Load_ID_Name_Staff();
            //Thay đổi width ch column Name
            DataGridViewColumn columnName = dtgvListStaff.Columns[1];
            columnName.Width = 295;
        }

        //Liên kết thông tin nhân viên
        private void AddStaffBinding()
        {
            txbIDStaff.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "ID"));
            txbNameStaff.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "Name"));
        }


        #endregion
    }
}
