using BUS;
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
    public partial class ClassCancelGUI : Form
    {
        
        public ClassCancelGUI()
        {

            InitializeComponent();
            LoadListStudent();
            //LoadClassStudentRegistration();
        }

        #region Events

        private void btnClassCancel_Click(object sender, EventArgs e)
        {
            string className = dtgvListClassStudentRegistration.CurrentRow.Cells[1].Value.ToString();
            string studentName = dtgvListStudent.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có thật sử muốn hủy môn học : " + className + "\ncủa sinh viên : " + studentName + " hay không ? ","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                ClassCancel();
            
        }

        private void btnExitView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeView_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dtgvListStudent_SelectionChanged(object sender, EventArgs e)
        {
            LoadClassStudentRegistration();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void LoadListStudent()
        {
            dtgvListStudent.DataSource = StudentService.Instance.GetIDNameStudent();
            //dtgvListStudent.Rows[0].Selected = true;
        }

        private void LoadClassStudentRegistration()
        {
            
            int idStudent = (int)(dtgvListStudent.CurrentRow.Cells[0].Value);
            dtgvListClassStudentRegistration.DataSource = ClassService.Instance.GetListClassStudentRegistration(idStudent);
        }

        private void ClassCancel()
        {
            int idStudent = (int)(dtgvListStudent.CurrentRow.Cells[0].Value);
            int idClass = (int)(dtgvListClassStudentRegistration.CurrentRow.Cells[0].Value);
            if (ClassInfoService.Instance.DeleteClassInfo(idStudent, idClass))
                MessageBox.Show("Hủy môn học thành công","Thông báo",MessageBoxButtons.OK);
            else
                MessageBox.Show("Hủy môn học không thành công","Thông báo",MessageBoxButtons.OK);
        }



        #endregion

        
    }
}
