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
    public partial class fmUserAddForm : Form
    {
        public fmUserAddForm()
        {
            InitializeComponent();
        }

        private void mcBirthDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            var date = mcBirthDate.SelectionStart;
            txtBirthDate.Text = date.ToString("dd.MM.yyyy");
        }
    }
}
