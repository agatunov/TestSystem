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
    public partial class ControlPanelAdminForm : Form
    {
        public ControlPanelAdminForm()
        {
            InitializeComponent();
        }

        private void editDataTestBtn_Click(object sender, EventArgs e)
        {
            EditDataTestForm editDataTestForm = new EditDataTestForm();
            editDataTestForm.Show();
        }
    }
}
