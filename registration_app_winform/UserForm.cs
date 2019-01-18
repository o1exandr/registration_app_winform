using registration_app_winform.Model;
using SimpleCrypto;
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
    public partial class fmUserForm : Form
    {
        public int id = fmLoginForm.Id;

        public fmUserForm()
        {
            InitializeComponent();
        }

        private void fmUserForm_Load(object sender, EventArgs e)
        {
            //btCancel.Text = Convert.ToString(id);
            
            try
            {
                string conToDb = @"Data Source=dell7020\sqlexpress;Initial Catalog=GridUserForm;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conToDb))
                {
                    con.Open();

                    string query = "SELECT * FROM tblUsers, tblUserProfile "
                                 + $"WHERE tblUserProfile.Id = {id}";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.CommandText = query;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
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
                            IsActive = Convert.ToBoolean(reader["IsActive"]) 
                        };

                        lbFullNameInfo.Text = user.FullName;
                        lbEmailInfo.Text = user.Email;
                        lbBirthInfo.Text = Convert.ToDateTime(reader["DateBirth"]).ToString("dd.MM.yyyy") + " (" + user.Age.ToString() + " років)";
                        lbRoleInfo.Text = user.Role;
                        lbSexInfo.Text = user.Sex == true ? "чоловіча" : "жіноча";
                        lbStatusInfo.Text = user.IsActive == true ? "активний" : "забанений";
                        lbPhoneInfo.Text = user.Phone;
                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних\n\t{ex.Message}", ex.Message);
            }
        }

        private void fmUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPass.Checked)
                txtNewPass.PasswordChar = '\0';
            else
                txtNewPass.PasswordChar = '*';
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Пароль не може бути порожнім, внесіть значення");
            }
            else
            {
                ICryptoService cryptoService = new PBKDF2();
                string salt = cryptoService.GenerateSalt();
                string hashedPassword = cryptoService.Compute(txtNewPass.Text);

                try
                {
                    string strCon = @"Data Source=dell7020\sqlexpress;Initial Catalog=GridUserForm;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        {
                            con.Open();
                            SqlCommand command = new SqlCommand();
                            command.Connection = con;
                            string query = $"UPDATE [dbo].[tblUsers] SET Password = '{hashedPassword}', PasswordSalt = '{salt}' WHERE tblUsers.Id = {id}";
                            command.CommandText = query;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Пароль змінено");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка оновлення паролю {ex.Message}", ex.Message);
                }
            }
        }
    }


}
