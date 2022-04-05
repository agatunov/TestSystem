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
    public partial class EditDataTestForm : Form
    {
        public EditDataTestForm()
        {
            InitializeComponent();
            RefreshPage();
            
        }
        public void RefreshPage()
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                testsComboBox.Items.Clear();
                var tests = db.Tests;
                foreach (var test in tests)
                {
                    testsComboBox.Items.Add(test.Name);
                }
                try
                {
                    questionListBox.Items.Clear();
                    var currentTest = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var questions = db.Questions;
                    foreach (var question in questions)
                    {
                        if (question.TestId == currentTest.TestId)
                        {
                            questionListBox.Items.Add(question.Content);
                        }
                    }
                }
                catch
                {

                }
                finally
                {

                }
               
            }
        }

        private void addNewTestButton_Click(object sender, EventArgs e)
        {
            newTestNameField.Visible = true;
            saveTestButton.Visible = true;
        }

        private void saveTestButton_Click(object sender, EventArgs e)
        {
            if (newTestNameField.Text == "") MessageBox.Show("Введите название теста");
            else
            {
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    var searchTest = db.Tests.Where(x => x.Name == newTestNameField.Text).FirstOrDefault();
                    if (searchTest != null)
                    {
                        MessageBox.Show("Тест с таким названием уже существует");
                    }
                    else
                    {
                        var newTest = new Model.Test
                        {
                            Name = newTestNameField.Text
                        };
                        db.Tests.Add(newTest);
                        db.SaveChanges();
                        newTestNameField.Clear();
                        newTestNameField.Visible = false;
                        saveTestButton.Visible = false;
                        RefreshPage();
                    }
                }

            }
            
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var currentTest = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();

                var newQuestion = new Model.Question
                {
                    Content = "Новый вопрос",
                    TestId = currentTest.TestId
                };
                db.Questions.Add(newQuestion);
                db.SaveChanges();
                
            }
            RefreshPage();
        }

        private void deleteTestButton_Click(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var deleteTest = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                db.Tests.Remove(deleteTest);
                db.SaveChanges();
                RefreshPage();
            }
        }

        private void testsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                questionListBox.Items.Clear();
                var currentTest = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                var questions = db.Questions;
                foreach (var question in questions)
                {
                    if (question.TestId == currentTest.TestId)
                    {
                        questionListBox.Items.Add(question.Content);
                    }
                }
            }
                
        }

        private void questionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                
            }
        }
    }
}
