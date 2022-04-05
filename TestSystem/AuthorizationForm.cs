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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            
            if (loginField.Text == "" || passwordField.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    var user = db.Users.Where(x => x.Login == loginField.Text && x.Password == passwordField.Text).FirstOrDefault();
                    if (user != null)
                    {
                        switch (user.RoleId)
                        {
                            case 1:
                                ControlPanelAdminForm controlPanelAdminForm = new ControlPanelAdminForm();
                                controlPanelAdminForm.Show();
                                break;
                            case 2:
                                ControlPanelUserForm controlPanelUserForm = new ControlPanelUserForm(user);
                                controlPanelUserForm.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }

                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            loginField.Clear();
            passwordField.Clear();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
