using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "" || fullnameField.Text == "" || passwordField.Text == "" || password2Field.Text == "" || passwordField.Text != password2Field.Text) MessageBox.Show("Поля не заполнены или пароли не совпадают");
            else
            {
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    var user = db.Users.Where(x => x.Login == loginField.Text).FirstOrDefault();
                    if (user == null && ValidateSystem.ValidatePassword(passwordField.Text) && ValidateSystem.ValidateFullName(fullnameField.Text) && ValidateSystem.ValidateLogin(loginField.Text))
                    {
                        string[] fullname = fullnameField.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var newUser = new Model.User()
                        {
                            Login = loginField.Text,
                            Password = passwordField.Text,
                            Name = fullname[1],
                            Surname = fullname[0],
                            Patronymic = fullname[2],
                            RoleId = 2
                        };
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно!");
                        this.Close();
                    }
                    else if (!ValidateSystem.ValidatePassword(passwordField.Text)) MessageBox.Show("Пароль должен содержать заглавные и строчные латинские буквы, цифры, и быть длиной минимум в 6 символов");
                    else if (!ValidateSystem.ValidateFullName(fullnameField.Text)) MessageBox.Show("ФИО должно состоять из трёх слов и разделено пробелом. Пример: Гатунов Александр Павлович");
                    else if (!ValidateSystem.ValidateLogin(loginField.Text)) MessageBox.Show("Логин должен состоять из латинских букв и не содержать пробелов");
                    else MessageBox.Show("Пользователь с таким логином уже существует");
                }
            }
            
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            loginField.Clear();
            password2Field.Clear();
            passwordField.Clear();
            fullnameField.Clear();
        }
    }
}
