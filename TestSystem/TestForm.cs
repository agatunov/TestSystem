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
    public partial class TestForm : Form
    {
        public TestForm(Model.Test test, Model.User user)
        {
            InitializeComponent();
            fullNameLabel.Text = $"Ваше Ф.И.О: {user.Surname} {user.Name} {user.Patronymic}";
            testNameLabel.Text = test.Name;
            TestHelper.startTime = DateTime.Now;
            TestHelper.countRightAnswers = 0;
            TestHelper.testStartTime = DateTime.Now;
            TestHelper.testFininshTime = DateTime.Now.AddMinutes(60);
            TestHelper.testTimeDiff = TestHelper.testFininshTime.Subtract(TestHelper.testStartTime);
            TestHelper.testId = test.TestId;
            TestHelper.userId = user.UserId;
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var questions = db.Questions.Where(x => x.TestId == test.TestId);
                TestHelper.currentQuestion = 1;
                TestHelper.allCountQuestions = questions.Count();
            }
            TestHelper.pointsForQuestion = 100 / TestHelper.allCountQuestions;
            NextQuestion();
        }

        public void NextQuestion()
        {
            if (TestHelper.currentQuestion == TestHelper.allCountQuestions) MessageBox.Show("Вы ответили на все вопросы, завершите тест.");
            else
            {
                TestHelper.questionStartTime = DateTime.Now;
                TestHelper.questionFinishTime = DateTime.Now.AddMinutes(2);
                TestHelper.questionTimeDiff = TestHelper.questionFinishTime.Subtract(TestHelper.questionStartTime);
                using (Model.TestSystemEntities db = new Model.TestSystemEntities())
                {
                    int i = 1;
                    var questions = db.Questions.Where(x => x.TestId == TestHelper.testId);
                    foreach (var question in questions)
                    {
                        if (i == TestHelper.currentQuestion)
                        {
                            questionField.Text = question.Content;
                            var answers = db.Answers.Where(x => x.QuestionId == question.QuestionId);
                            int j = 1;
                            foreach (var answer in answers)
                            {
                                switch (j)
                                {
                                    case 1:
                                        answer1Button.Text = answer.Content;
                                        if (answer.Right) TestHelper.rightAnswer = 1;
                                        j++;
                                        break;
                                    case 2:
                                        answer2Button.Text = answer.Content;
                                        if (answer.Right) TestHelper.rightAnswer = 2;
                                        j++;
                                        break;
                                    case 3:
                                        answer3Button.Text = answer.Content;
                                        if (answer.Right) TestHelper.rightAnswer = 3;
                                        j++;
                                        break;
                                    case 4:
                                        answer4Button.Text = answer.Content;
                                        if (answer.Right) TestHelper.rightAnswer = 4;
                                        j++;
                                        break;
                                }

                            }
                            break;
                        }
                        i++;
                    }
                    TestHelper.currentQuestion = TestHelper.currentQuestion + 1;

                }
            }
          
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TestHelper.questionStartTime = DateTime.Now;
            TestHelper.questionTimeDiff = TestHelper.questionFinishTime.Subtract(TestHelper.questionStartTime);
            timeQuestionLabel.Text = $"Времени на данный вопрос: {TestHelper.questionTimeDiff.Minutes}:{TestHelper.questionTimeDiff.Seconds}";
            TestHelper.testStartTime = DateTime.Now;
            TestHelper.testTimeDiff = TestHelper.testFininshTime.Subtract(TestHelper.testStartTime);
            timeTestLabel.Text = $"Времени на весь тест: {TestHelper.testTimeDiff.Minutes}:{TestHelper.testTimeDiff.Seconds}";
            if (TestHelper.questionStartTime > TestHelper.questionFinishTime) NextQuestion();
            if (TestHelper.testStartTime > TestHelper.testFininshTime) toCompleteButton_Click(sender, e);
        }

        private void toAnswerButton_Click(object sender, EventArgs e)
        {

            switch (TestHelper.rightAnswer)
            {
                case 1:
                    if (answer1Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 2:
                    if (answer2Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 3:
                    if (answer3Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
                case 4:
                    if (answer4Button.Checked) TestHelper.countRightAnswers += 1;
                    break;
            }
            NextQuestion();
        }

        private void toCompleteButton_Click(object sender, EventArgs e)
        {
            TestHelper.finishTime = DateTime.Now;
            using (Model.TestSystemEntities db = new Model.TestSystemEntities())
            {
                var finishTest = new Model.FinishedTest
                {
                    TestId = TestHelper.testId,
                    UserId = TestHelper.userId,
                    Points = TestHelper.countRightAnswers * TestHelper.pointsForQuestion,
                    Time = TestHelper.finishTime.Subtract(TestHelper.startTime),
                    DateEnd = TestHelper.testFininshTime
                };
                db.FinishedTests.Add(finishTest);
                db.SaveChanges();             
            }
            this.Close();
        }
    }
}
