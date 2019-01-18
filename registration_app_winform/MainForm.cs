using registration_app_winform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            /*
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
            */

            try
            {


                string conToDb = @"Data Source=dell7020\sqlexpress;Initial Catalog=GridUserForm;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conToDb))
                {
                    con.Open();

                    string query = "SELECT * FROM tblUsers, tblUserProfile "
                                 + "WHERE tblUsers.Id = tblUserProfile.Id ";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.CommandText = query;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan span = DateTime.Now - Convert.ToDateTime(reader["DateBirth"]);
                        var user = new UserItemModel
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            FullName = reader["Lastname"].ToString() + " " + reader["Firstname"].ToString() + " " + reader["Secondname"].ToString(),
                            Email = reader["Email"].ToString(),
                            Role = reader["Role"].ToString(),
                            Age = span.Days / 365,
                            Phone = reader["Phone"].ToString(),
                            Sex = Convert.ToBoolean(reader["Sex"]),
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
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних\n\t{ex.Message}", ex.Message);
            }
        }
    }
}
