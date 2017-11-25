using BUS;
using DTO;
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
    public partial class AddClassGUI : Form
    {
        int IDStaff;
        int IDSubject;

        public AddClassGUI()
        {
            InitializeComponent();
            SetDay();
            LoadcbStaff();
            LoadcbSubject();

            
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClass();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpkDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtpkDateStart.MaxDate = dtpkDateEnd.Value.AddDays(-1);
        }

        private void dtpkDateEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpkDateStart.MaxDate = dtpkDateEnd.Value.AddDays(-1);
        }

        #endregion

        #region Methods
        // ràng buộc ngày
        private void SetDay()
        {
            //Ngày kết thúc
            dtpkDateEnd.MinDate = DateTime.Now.AddDays(7);
            dtpkDateEnd.Value = DateTime.Now.AddDays(7);

            //Ngày bắt đầu
            dtpkDateStart.MinDate = DateTime.Now;
            dtpkDateStart.Value = DateTime.Now;
            dtpkDateStart.MaxDate = dtpkDateEnd.Value.AddDays(-1);               
        }

        // load môn học
        private void LoadcbSubject()
        {
            List<Subject> subjectList = SubjectService.Instance.GetListSubject();

            cbSubject.DisplayMember = "Name";
            cbSubject.ValueMember = "ID";

            foreach(Subject subject in subjectList)
            {
                cbSubject.Items.Add(subject);
            }

            //cbSubject.Text = cbSubject.Items[0].ToString();
            
           
        }

        // load nhân viên
        private void LoadcbStaff()
        {
            List<Staff> staffList = StaffService.Instance.GetListStaff();

            cbStaff.DisplayMember = "Name";
            cbStaff.ValueMember = "ID";

            foreach (Staff staff in staffList)
            {
                if (staff.Type == true)
                {
                    cbStaff.Items.Add(staff);
                }
            }

            //cbStaff.Text = cbStaff.Items[0].ToString();
            
        }

        // thêm lớp
        private void AddClass()
        {
            if(Utility.CheckTextBoxEmpty(txbName) && cbSubject.Text != "" && cbStaff.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn thêm lớp học này không ?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string name = txbName.Text;
                    int idSubject = ((Subject)cbSubject.SelectedItem).ID;
                    int idStaff = ((Staff)cbStaff.SelectedItem).ID;
                    DateTime dateStart = dtpkDateStart.Value;
                    DateTime dateEnd = dtpkDateEnd.Value;

                    Class cl = new Class(name, "", dateStart, dateEnd, idSubject, idStaff);

                    if (ClassService.Instance.AddClass(cl))
                    {
                        MessageBox.Show("Thêm lớp học thành công.", "Thông báo", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thêm lớp học không thành công.","Thông báo",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ !","Thông báo", MessageBoxButtons.OK);
            }
        }




        #endregion

        
    }
}
