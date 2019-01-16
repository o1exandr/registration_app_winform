using registration_app_winform.Model;
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

        private void fmMain_Load(object sender, EventArgs e)
        {
            var user = new UserItemModel
            {
                Id = 1,
                FullName = "Сидор Славік Сидорович",
                Email = "ss@ss.ss",
                Role = "Admin",
                Age = 12,
                Phone = "+3809734128745",
                Sex = true
            };
            string sex = user.Sex == true ? "чоловіча" : "жіноча";
            object[] row =
            {
                user.Id, user.FullName, user.Email, user.Phone, user.Role, user.Age, sex
            };
            dvgUsers.Rows.Add(row);
        }
    }
}
