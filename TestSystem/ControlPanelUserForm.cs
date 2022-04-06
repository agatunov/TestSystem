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
    public partial class ControlPanelUserForm : Form
    {
        public ControlPanelUserForm(Model.User user)
        {       
            InitializeComponent();
            loginFieldLabel.Text = user.Login;
            fullnameFieldLabel.Text = user.Surname + " " + user.Name + " " + user.Patronymic;
            EditHelper.userId = user.UserId;
            RefreshPage();
        }
        public void RefreshPage() //Перезагрузка страницы
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                testsComboBox.Items.Clear();
                var tests = db.Tests;
                foreach (var test in tests)
                {
                    testsComboBox.Items.Add(test.Name);
                }
            }
        }

            private void editDataBtn_Click(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var user = db.Users.Where(x => x.Login == loginFieldLabel.Text).FirstOrDefault();
                EditDataUserForm editDataUserForm = new EditDataUserForm(user);
                editDataUserForm.Show();
                this.Close();
            }
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            if (testsComboBox.SelectedItem.ToString() == "") MessageBox.Show("Вы должны выбрать тест");
            else
            {
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    var test = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var user = db.Users.Where(x => x.UserId == EditHelper.userId).FirstOrDefault();
                    TestForm testForm = new TestForm(test, user);
                    testForm.Show();
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
