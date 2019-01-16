using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;
using registration_app_winform.Model;
using SimpleCrypto;

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

        private void btAddUser_Click(object sender, EventArgs e)
        {
            UserAddModel user = new UserAddModel()
            {
                Lastname = txtLastName.Text,
                Name = txtName.Text,
                Secondname = txtSecondName.Text,
                DateBirth = txtBirthDate.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Phone = txtPhone.Text,
                Sex = rbMale.Checked ? true : false,
                Role = cbRole.Text
            };
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    string strCon = @"Data Source=dell7020\sqlexpress;Initial Catalog=GridUserForm;Integrated Security=True";
                    ICryptoService cryptoService = new PBKDF2();
                    //New User
                    //string password = "password";

                    //save this salt to the database
                    string salt = cryptoService.GenerateSalt();

                    //save this hash to the database
                    string hashedPassword = cryptoService.Compute(user.Password);

                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = con;
                        var query = $"INSERT INTO [dbo].[tblUsers] ([Email],[Password],[PasswordSalt],[Role],[IsActive]) VALUES('{user.Email}','{hashedPassword}','{salt}', '{user.Role}', 1)";
                        command.CommandText = query;
                        int userId = 0;
                        var count = command.ExecuteNonQuery();
                        if (count == 1)
                        {
                            query = "SELECT SCOPE_IDENTITY() AS UserId";
                            command.CommandText = query;
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                userId = int
                                    .Parse(reader["UserId"].ToString());
                            }
                            reader.Close();
                        }
                        else { throw new Exception("Проблема при добавлені користувача"); }
                        string dateBirth = DateTime.ParseExact(user.DateBirth, "dd.MM.yyyy", null).ToString("yyyy-MM-dd");
                        query = "SET IDENTITY_INSERT tblUserProfile ON " // видавало помилку про те що SET IDENTITY_INSERT tblUserProfile OFF, змушений був додати цей код, що він робить не розумію
                            + "INSERT INTO [dbo].[tblUserProfile] ([Id],[Lastname],[Firstname],[Secondname],[DateBirth],[Phone],[Sex],[Image]) " +
                            $"VALUES({userId}, '{user.Lastname}', '{user.Name}', '{user.Secondname}', '{dateBirth}', '{user.Phone}', '{user.Sex}', NULL)"
                            //$"VALUES({userId}, 'Юзеренко', 'Юзер', 'Юзерович', '{dateBirth}', '+38067 ХХХ ХХ ХХ', '1', NULL)"
                            + " SET IDENTITY_INSERT tblUserProfile OFF";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        
                    }
                    scope.Complete();
                    MessageBox.Show($"Користувача {user.Lastname} {user.Name} з роллю {user.Role} додано");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних {ex.Message}", ex.Message);
            }


        }
    }
}
