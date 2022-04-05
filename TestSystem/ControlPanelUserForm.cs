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
        }

        private void editDataBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
