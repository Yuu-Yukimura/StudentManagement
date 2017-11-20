using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UserCtlNew
{
    public partial class ucViewStudent : UserControl
    {
        public ucViewStudent()
        {
            InitializeComponent();
        }

        public ucViewStudent(string id)
        {
            int ID = int.Parse(id);
        }
    }
}
