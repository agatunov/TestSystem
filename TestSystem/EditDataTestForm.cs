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
        public void RefreshQuestionsList()
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                questionListBox.Items.Clear();
                var currentTest = db.Tests.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
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



        private void addNewTestButton_Click(object sender, EventArgs e) //Добавить новый тест
        {
            newTestNameField.Visible = true;
            saveTestButton.Visible = true;
        }

        private void saveTestButton_Click(object sender, EventArgs e) //Сохранить тест
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

        private void addNewQuestionButton_Click(object sender, EventArgs e) // Добавить новый вопрос
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var currentTest = db.Tests.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
                var questions = db.Questions.Where(x => x.TestId == currentTest.TestId);        
                var newQuestion = new Model.Question
                {
                    Content = "Новый вопрос" + (questions.Count()+1).ToString(),
                    TestId = currentTest.TestId
                };

                db.Questions.Add(newQuestion);

                 for (int i = 0; i < 4; i++)
                {
                    var newAnswer = new Model.Answer
                    {
                        Content = "Введите ответ",
                        QuestionId = newQuestion.QuestionId,
                        Right = false
                    };
                    db.Answers.Add(newAnswer);
                }

                 


                db.SaveChanges();
                
            }
            RefreshPage();
            RefreshQuestionsList();
        }

        private void deleteTestButton_Click(object sender, EventArgs e) // Удалить тест
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var deleteTest = db.Tests.Where(x => x.Name == RefreshPageHelper.selectedTest).FirstOrDefault();
                var deleteQuestions = db.Questions.Where(x => x.TestId == deleteTest.TestId);
                foreach (var deleteQuestion in deleteQuestions)
                {
                    var deleteAnswers = db.Answers.Where(x => x.QuestionId == deleteQuestion.QuestionId);
                    db.Answers.RemoveRange(deleteAnswers);
                }
                db.Questions.RemoveRange(deleteQuestions);
                db.Tests.Remove(deleteTest);
                db.SaveChanges();
                RefreshPage();
            }
        }

        private void testsComboBox_SelectedIndexChanged(object sender, EventArgs e) // Выбор теста
        {
            
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                questionListBox.Items.Clear();
                var currentTest = db.Tests.Where(x => x.Name == testsComboBox.SelectedItem.ToString()).FirstOrDefault();
                RefreshPageHelper.selectedTest = currentTest.Name;
                RefreshPageHelper.selectedTestId = currentTest.TestId;
                var questions = db.Questions;
                foreach (var question in questions)
                {
                    if (question.TestId == currentTest.TestId)
                    {
                        questionListBox.Items.Add(question.Content);
                    }
                }
            }
            questionNameField.Clear();
            answer1Field.Clear();
            answer2Field.Clear();
            answer3Field.Clear();
            answer4Field.Clear();
            RefreshQuestionsList();

        }

        private void questionListBox_SelectedIndexChanged(object sender, EventArgs e) // Выбор вопроса
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                int i = 1;
                var question = db.Questions.Where(x => x.TestId == RefreshPageHelper.selectedTestId && x.Content == questionListBox.SelectedItem.ToString()).FirstOrDefault();
                RefreshPageHelper.selectedQuestionId = question.QuestionId;
                questionNameField.Text = question.Content;
                var answers = db.Answers.Where(x => x.QuestionId == question.QuestionId);
                foreach (var answer in answers)
                {
                    switch (i)
                    {
                        case 1:
                            answer1Field.Text = answer.Content;
                            asnwer1RightButton.Checked = answer.Right;
                            i++;
                            break;
                        case 2:
                            answer2Field.Text = answer.Content;
                            asnwer2RightButton.Checked = answer.Right;
                            i++;
                            break;
                        case 3:
                            answer3Field.Text = answer.Content;
                            asnwer3RightButton.Checked = answer.Right;
                            i++;
                            break;
                        case 4:
                            answer4Field.Text = answer.Content;
                            asnwer4RightButton.Checked = answer.Right;
                            i++;
                            break;
                    }

                }
            }
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e) //Удаление вопроса
        {
            
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    var deleteQuestion = db.Questions.Where(x => x.Content == questionListBox.SelectedItem.ToString()).FirstOrDefault();
                    var deleteAnswers = db.Answers.Where(x => x.QuestionId == deleteQuestion.QuestionId);
                    db.Answers.RemoveRange(deleteAnswers);
                    db.Questions.Remove(deleteQuestion);
                    db.SaveChanges();
                }
            RefreshPage();
            RefreshQuestionsList();

        }

        private void asnwer1RightButton_CheckedChanged(object sender, EventArgs e) //Выбор правильного ответа 1
        {
       
            asnwer2RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer2RightButton_CheckedChanged(object sender, EventArgs e) //Выбор правильного ответа 2
        {
    
            asnwer1RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer3RightButton_CheckedChanged(object sender, EventArgs e) //Выбор правильного ответа 3
        {
 
            asnwer2RightButton.Checked = false;
            asnwer1RightButton.Checked = false;
            asnwer4RightButton.Checked = false;
        }

        private void asnwer4RightButton_CheckedChanged(object sender, EventArgs e) //Выбор правильного ответа 4
        {
            
            asnwer2RightButton.Checked = false;
            asnwer3RightButton.Checked = false;
            asnwer1RightButton.Checked = false;
        }

        private void saveQuestionButton_Click(object sender, EventArgs e)
        {
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                if (questionNameField.Text == "" || answer1Field.Text == "" || answer2Field.Text == "" || answer3Field.Text == "" || answer4Field.Text == "") MessageBox.Show("Поля не заполнены");
                else if (!asnwer1RightButton.Checked && !asnwer2RightButton.Checked && !asnwer3RightButton.Checked && !asnwer4RightButton.Checked) MessageBox.Show("Должен быть выбран правильный ответ");
                else
                {
                    int i = 1;
                    var question = db.Questions.Where(x => x.QuestionId == RefreshPageHelper.selectedQuestionId).FirstOrDefault();
                    question.Content = questionNameField.Text;
                    var answers = db.Answers.Where(x => x.QuestionId == question.QuestionId);
                    foreach (var answer in answers)
                    {
                        switch (i)
                        {
                            case 1:
                                answer.Content = answer1Field.Text;
                                answer.Right = asnwer1RightButton.Checked;
                                i++;
                                break;
                            case 2:
                                answer.Content = answer2Field.Text;
                                answer.Right = asnwer2RightButton.Checked;
                                i++;
                                break;
                            case 3:
                                answer.Content = answer3Field.Text;
                                answer.Right = asnwer3RightButton.Checked;
                                i++;
                                break;
                            case 4:
                                answer.Content = answer4Field.Text;
                                answer.Right = asnwer4RightButton.Checked;
                                i++;
                                break;
                        }

                    }
                    db.SaveChanges();
                    RefreshQuestionsList();
                }
            }
        }
    }
}
