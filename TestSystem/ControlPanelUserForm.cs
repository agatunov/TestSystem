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

        public struct TestResult
        {
            public string testName;
            public string result;
            public TimeSpan time;
            public int points;
            public DateTime dateEnd;

            public TestResult(string _testName, string _result, TimeSpan _time, int _points, DateTime _dateEnd)
            {
                testName = _testName;
                result = _result;
                time = _time;
                points = _points;
                dateEnd = _dateEnd;
            }

        }
        List<TestResult> testResults = new List<TestResult>();

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
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                testHistoryDataGrid.Rows.Clear();
                testHistoryDataGrid.Refresh();
                testResults = new List<TestResult>();
                var finishTests = db.FinishedTests.Where(x => x.UserId == EditHelper.userId);
                foreach (var finishTest in finishTests)
                {
                    var test = db.Tests.Where(x => x.TestId == finishTest.TestId).FirstOrDefault();
                    string result = "";
                    if (finishTest.Points >= 70) result = "Зачёт";
                    else result = "Незачёт";
                    TimeSpan time = finishTest.Time;
                    int points = finishTest.Points;
                    DateTime dateEnd = finishTest.DateEnd;
                    testResults.Add(new TestResult(test.Name, result, time, points, dateEnd));
                }
                foreach (var testResult in testResults)
                {
                    testHistoryDataGrid.Rows.Add(testResult.testName, testResult.result, testResult.time, testResult.points, testResult.dateEnd);
                }
            }
        }

        private void testHistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (testResults[e.RowIndex].points >= 70)
            {
                getCertificateBtn.Enabled = true;
            }
            else
            {
                getCertificateBtn.Enabled =false;
            }
        }
    }
}
