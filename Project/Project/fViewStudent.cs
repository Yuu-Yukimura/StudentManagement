using Project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class fViewStudent : Form
    {
        int ID;
        public fViewStudent(string id)
        {
            InitializeComponent();
            ID = int.Parse(id);


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
        //Sẽ lưu toàn bộ thông tinh vừa chỉnh sửa vào csdl bằng id
        private void btnEditViewStudent_Click(object sender, EventArgs e)
        {
            string name = txbNameViewStudent.Text;
            byte[] avatar = new byte[] { };
            string address = txbAddressViewStudent.Text;
            string phone = txbPhoneViewStudent.Text;
            string parentPhone = txbParentPhoneViewStudent.Text;
            Boolean sex = ConvertSexToBoolean();
            DateTime dateOfBirth = dtpkDateOfBirthViewStudent.Value.Date;

            StudentDAO.Instance.EditStudentById(ID, name, avatar, sex, dateOfBirth, address, phone, parentPhone);

        }

        #endregion

        #region Method

        //Load thông tin sinh viên có id = id lên các controls
        private void LoadView()
        {
            DataTable data = StudentDAO.Instance.LoadStudentById(ID);

            lbHeadlineViewStudent.Text += data.Rows[0]["Sex"].ToString();
            txbNameViewStudent.Text = data.Rows[0]["Name"].ToString();
            txbAddressViewStudent.Text = data.Rows[0]["Address"].ToString();
            txbPhoneViewStudent.Text = data.Rows[0]["Phone"].ToString();
            txbParentPhoneViewStudent.Text = data.Rows[0]["ParentPhone"].ToString();

            if (data.Rows[0]["Sex"].ToString() == "True")
                rdbMaleViewStudent.Checked = true;
            else
                rdbFemaleViewStudent.Checked = true;

            dtpkDateOfBirthViewStudent.Text = data.Rows[0]["DateOfBirth"].ToString();

        }

        private Boolean ConvertSexToBoolean()
        {
            if(rdbMaleViewStudent.Checked = true)
                return true;
            return false;        
        }

        #endregion

       
    }
}
