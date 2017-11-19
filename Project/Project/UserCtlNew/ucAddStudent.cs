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
    public partial class ucAddStudent : UserControl
    {
        public ucAddStudent()
        {
            InitializeComponent();
        }

        private void pbxAvatar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
