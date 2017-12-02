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
    public partial class ViewDebtInfoGUI : Form
    {
        int IDDebt;
        int IDStudent;

        public ViewDebtInfoGUI(int idDebt, int idStudent)
        {
            IDDebt = idDebt;
            IDStudent = idStudent;
            InitializeComponent();
            LoadView(idDebt, idStudent);
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

        private void dtgvListDebt_SelectionChanged(object sender, EventArgs e)
        {
            //LoadView(IDDebt, IDStudent);
        }

        #endregion

        #region Methods

        private void LoadView(int idDebt, int idStudent)
        {
            Student student = StudentService.Instance.GetStudentByID(idStudent);
            Debt debt = DebtService.Instance.GetDebtByID(idDebt);

            txbIDDebt.Text = debt.ID.ToString();
            txbIDStudent.Text = student.ID.ToString();
            txbNameStudent.Text = student.Name.ToString();
            txbSumOfDebt.Text = debt.SumOfDebt.ToString();
            pbxAvatarStudent.Image = Utility.ByteArrayToImage(student.Avatar);

            dtgvListDebt.DataSource = DebtInfoService.Instance.GetListDebtInfo(debt.ID);
            dtgvListDebt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        #endregion

        
    }
}
