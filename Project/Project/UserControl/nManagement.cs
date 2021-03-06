﻿using System;
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

        #region Sinh viên
        //
        // Sinh viên
        //
        //Click vào nút xem thông tin sinh viên
        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            fViewStudent f = new fViewStudent(txbIDStudent.Text);
            f.ShowDialog();
            LoadStudent();
            AddStudentBinding();
        }

        //Click vào nút thêm sinh viên
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            fAddStudent f = new fAddStudent();
            f.ShowDialog();
            LoadStudent();
            AddStudentBinding();
        }

        //Click vào nút xóa sinh viên
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa sinh viên này ko ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (StudentDAO.Instance.DeleteStudent(int.Parse(txbIDStudent.Text)))
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

        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Môn
        //
        // Môn học
        //
        private void btnAddSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {

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