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
    public partial class ClassRegistrationGUI : Form
    {
        public ClassRegistrationGUI()
        {
            InitializeComponent();
            LoadListStudent();
            LoadListClass();
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

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string nameStudent = dtgvListStudent.CurrentRow.Cells[1].Value.ToString();
            string nameClass = dtgvListClass.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm sinh viên : " + nameStudent + "\n vào lớp : " + nameClass + "  không ??", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Registration();
            }
        }

        #endregion

        #region Methods

        private void LoadListStudent()
        {
            dtgvListStudent.DataSource = StudentService.Instance.GetIDNameStudent();
            dtgvListStudent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadListClass()
        {
            dtgvListClass.DataSource = ClassService.Instance.GetIDNameClass();
            dtgvListClass.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Registration()
        {
            int idStudent = (int)dtgvListStudent.CurrentRow.Cells[0].Value;
            int idClass = (int)dtgvListClass.CurrentRow.Cells[0].Value;
            ClassInfo classInfo = new ClassInfo(idClass, idStudent);

            if (ClassInfoService.Instance.AddClassInfo(classInfo))
            {
                AddDebt();
                MessageBox.Show("Bạn đã thêm lớp học thành công","Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn thêm không thành công, có thể sinh viên đã đăng ký lớp học này rồi !!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void AddDebt()
        {
            DataTable data = DebtService.Instance.GetIdDebtByIdStudent((int)dtgvListStudent.CurrentRow.Cells[0].Value);
            int idDebt = (int)data.Rows[0]["id"];
            DateTime date = DateTime.Now;
            decimal money = (decimal)dtgvListClass.CurrentRow.Cells[2].Value;

            DebtInfo debtInfo = new DebtInfo(money, date, idDebt);
            DebtInfoService.Instance.AddDebtInfo(debtInfo);

        }

        #endregion


    }
}
