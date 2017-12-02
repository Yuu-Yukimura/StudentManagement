using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.UserControls
{
    public partial class ucMainList : UserControl
    {
        public ucMainList()
        {
            InitializeComponent();
            LoadStatusClass();
            LoadListClass();

        }

        #region Events

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListStudentInClass();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListClass();
        }

        #endregion

        #region Methods

        //Load tình trạng lớp
        private void LoadStatusClass()
        {
            cbStatus.Items.Add("Đang mở");
            cbStatus.Items.Add("Vào học");
            cbStatus.Items.Add("Kết thúc");

            if(cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;
        }

        //Load list class lên combobox
        private void LoadListClass()
        {
            List<Class> list = ClassService.Instance.GetListClassByStatus(cbStatus.Text);

            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "ID";

            foreach(Class cls in list)
            {
                cbClass.Items.Add(cls);
            }

            if(cbClass.Items.Count > 0)
                cbClass.SelectedIndex = 0;
        }

        //Load list Student trong lớp học
        private void LoadListStudentInClass()
        {
            int idClass = ((Class)cbClass.SelectedItem).ID;
            dtgvListStudentInClass.DataSource = StudentService.Instance.GetIDNameStudentInClassByIDClass(idClass);
            dtgvListStudentInClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        #endregion

        
    }
}
