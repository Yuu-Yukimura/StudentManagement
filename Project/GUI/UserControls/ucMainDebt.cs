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

namespace GUI.UserControls
{
    public partial class ucMainDebt : UserControl
    {
        public ucMainDebt()
        {
            InitializeComponent();
            LoadListDebt();
            AddBindingDebt();
        }

        #region Events

        private void btnViewDebt_Click(object sender, EventArgs e)
        {
            ViewDebtInfoGUI f = new ViewDebtInfoGUI((int.Parse(txbIDDebt.Text)),(int.Parse(txbIDStudent.Text)));
            f.Show();
        }

        #endregion

        #region Methods

        private void LoadListDebt()
        {
            dtgvListDebt.DataSource = DebtService.Instance.GetListDebt();
        }

        private void AddBindingDebt()
        {
            txbIDDebt.DataBindings.Clear();
            txbIDStudent.DataBindings.Clear();
            txbNameStudent.DataBindings.Clear();
            txbSumOfDebt.DataBindings.Clear();
            pbxAvatarStudent.DataBindings.Clear();
            txbIDDebt.DataBindings.Add(new Binding("Text", dtgvListDebt.DataSource, "Mã nợ"));
            txbIDStudent.DataBindings.Add(new Binding("Text", dtgvListDebt.DataSource, "Mã sinh viên"));
            txbNameStudent.DataBindings.Add(new Binding("Text", dtgvListDebt.DataSource, "Tên sinh viên"));
            txbSumOfDebt.DataBindings.Add(new Binding("Text", dtgvListDebt.DataSource, "Tổng nợ"));
            pbxAvatarStudent.DataBindings.Add(new Binding("Image", dtgvListDebt.DataSource, "avatar",true));
        }

        #endregion

        
    }
}
