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
    public partial class fmLoginForm : Form
    {
        private int _id;
        private string _login;
        private string _hashedPassword;
        private string _salt;
        private string _role;
        private bool _active;

        public static int Id { get; set; }

        public fmLoginForm()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            // зчитуємо дані введені користувачем
            string strLogin = txtLogin.Text;
            string strPassword = txtPassword.Text;

            // шукаємо чи є відповідний логін, якщо так, то записуємо собі ці дані для подальшої перевірки
            try
            {
                string conToDb = @"Data Source=dell7020\sqlexpress;Initial Catalog=GridUserForm;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(conToDb))
                {
                    con.Open();

                    string query = "SELECT * FROM tblUsers";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.CommandText = query;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Email"].ToString() == strLogin)
                        {
                            Id = int.Parse(reader["Id"].ToString());
                            _login = reader["Email"].ToString();
                            _hashedPassword = reader["Password"].ToString();
                            _salt = reader["PasswordSalt"].ToString();
                            _role = reader["Role"].ToString();
                            _active = Convert.ToBoolean(reader["IsActive"].ToString());
                            break;
                        }
                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних\n\t{ex.Message}", ex.Message);
            }
            

            // Шукаємо користувача по даному логіну в БД
            if (strLogin == _login)
            {
                ICryptoService cryptoService = new PBKDF2();
                //validate user
                //compare the password (this should be true since we are rehashing the same password and using the same generated salt)
                string hashedPassword2 = cryptoService.Compute(strPassword, _salt);

                if (_hashedPassword == hashedPassword2)
                {
                    //MessageBox.Show("Вхід успішний");
                    if (_role == "Admin" && _active)
                    {
                        fmMain main = new fmMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                        if (_role == "User" && _active)
                        {
                            //MessageBox.Show("Ви війшли як юзер");
                            fmUserForm user = new fmUserForm();
                            user.Show();
                            this.Hide();
                        }
                        else
                        if (_active == false)
                            {
                                MessageBox.Show("\tВи не активний користувач\nАдмін відключив вам змогу користуватись базою");
                            }


                }
                else
                {
                    MessageBox.Show("Не валідні дані");
                }
            }
            else
            {
                MessageBox.Show("Не валідні дані");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
