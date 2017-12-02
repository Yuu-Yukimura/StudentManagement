using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucMainHome : UserControl
    {
        public ucMainHome()
        {
            InitializeComponent();
        }

        #region Events

        private void btnClassRegistration_Click(object sender, EventArgs e)
        {
            ClassRegistrationGUI f = new ClassRegistrationGUI();
            f.Show();
        }

        private void btnClassCancel_Click(object sender, EventArgs e)
        {
            ClassCancelGUI f = new ClassCancelGUI();
            f.Show();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffGUI f = new AddStaffGUI();
            f.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentGUI f = new AddStudentGUI();
            f.Show();
        }

        private void btnPayDebt_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}
