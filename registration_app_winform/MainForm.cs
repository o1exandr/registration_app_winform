using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_app_winform
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            fmUserAddForm UserAddForm = new fmUserAddForm();
            UserAddForm.ShowDialog();
        }
    }
}
