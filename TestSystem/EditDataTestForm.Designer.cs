
namespace TestSystem
{
    partial class EditDataTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addNewTestButton = new System.Windows.Forms.Button();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.questionNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.answer1Field = new System.Windows.Forms.TextBox();
            this.answer2Field = new System.Windows.Forms.TextBox();
            this.answer3Field = new System.Windows.Forms.TextBox();
            this.answer4Field = new System.Windows.Forms.TextBox();
            this.asnwer1RightButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.asnwer2RightButton = new System.Windows.Forms.RadioButton();
            this.asnwer3RightButton = new System.Windows.Forms.RadioButton();
            this.asnwer4RightButton = new System.Windows.Forms.RadioButton();
            this.saveQuestionButton = new System.Windows.Forms.Button();
            this.deleteTestButton = new System.Windows.Forms.Button();
            this.saveTestButton = new System.Windows.Forms.Button();
            this.newTestNameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testsComboBox
            // 
            this.testsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(37, 91);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(1196, 32);
            this.testsComboBox.TabIndex = 0;
            this.testsComboBox.SelectedIndexChanged += new System.EventHandler(this.testsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(645, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тесты";
            // 
            // questionListBox
            // 
            this.questionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.ItemHeight = 24;
            this.questionListBox.Location = new System.Drawing.Point(37, 284);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(461, 340);
            this.questionListBox.TabIndex = 3;
            this.questionListBox.SelectedIndexChanged += new System.EventHandler(this.questionListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вопросы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(855, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Редактирование";
            // 
            // addNewTestButton
            // 
            this.addNewTestButton.BackColor = System.Drawing.Color.White;
            this.addNewTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewTestButton.Location = new System.Drawing.Point(1239, 91);
            this.addNewTestButton.Name = "addNewTestButton";
            this.addNewTestButton.Size = new System.Drawing.Size(39, 34);
            this.addNewTestButton.TabIndex = 6;
            this.addNewTestButton.Text = "+";
            this.addNewTestButton.UseVisualStyleBackColor = false;
            this.addNewTestButton.Click += new System.EventHandler(this.addNewTestButton_Click);
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.BackColor = System.Drawing.Color.White;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewQuestionButton.Location = new System.Drawing.Point(37, 630);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(191, 40);
            this.addNewQuestionButton.TabIndex = 7;
            this.addNewQuestionButton.Text = "Добавить вопрос";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestionButton_Click);
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.BackColor = System.Drawing.Color.White;
            this.deleteQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteQuestionButton.Location = new System.Drawing.Point(303, 630);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(195, 40);
            this.deleteQuestionButton.TabIndex = 8;
            this.deleteQuestionButton.Text = "Удалить вопрос";
            this.deleteQuestionButton.UseVisualStyleBackColor = false;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(531, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вопрос:";
            // 
            // questionNameField
            // 
            this.questionNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNameField.Location = new System.Drawing.Point(618, 284);
            this.questionNameField.Name = "questionNameField";
            this.questionNameField.Size = new System.Drawing.Size(615, 29);
            this.questionNameField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(531, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ответ 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(531, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ответ 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(531, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ответ 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(531, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ответ 4:";
            // 
            // answer1Field
            // 
            this.answer1Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1Field.Location = new System.Drawing.Point(618, 340);
            this.answer1Field.Name = "answer1Field";
            this.answer1Field.Size = new System.Drawing.Size(615, 29);
            this.answer1Field.TabIndex = 15;
            // 
            // answer2Field
            // 
            this.answer2Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2Field.Location = new System.Drawing.Point(618, 373);
            this.answer2Field.Name = "answer2Field";
            this.answer2Field.Size = new System.Drawing.Size(615, 29);
            this.answer2Field.TabIndex = 16;
            // 
            // answer3Field
            // 
            this.answer3Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3Field.Location = new System.Drawing.Point(618, 408);
            this.answer3Field.Name = "answer3Field";
            this.answer3Field.Size = new System.Drawing.Size(615, 29);
            this.answer3Field.TabIndex = 17;
            // 
            // answer4Field
            // 
            this.answer4Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer4Field.Location = new System.Drawing.Point(618, 443);
            this.answer4Field.Name = "answer4Field";
            this.answer4Field.Size = new System.Drawing.Size(615, 29);
            this.answer4Field.TabIndex = 18;
            // 
            // asnwer1RightButton
            // 
            this.asnwer1RightButton.AutoSize = true;
            this.asnwer1RightButton.Location = new System.Drawing.Point(535, 528);
            this.asnwer1RightButton.Name = "asnwer1RightButton";
            this.asnwer1RightButton.Size = new System.Drawing.Size(31, 17);
            this.asnwer1RightButton.TabIndex = 19;
            this.asnwer1RightButton.TabStop = true;
            this.asnwer1RightButton.Text = "1";
            this.asnwer1RightButton.UseVisualStyleBackColor = true;
            this.asnwer1RightButton.CheckedChanged += new System.EventHandler(this.asnwer1RightButton_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(739, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(385, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Выберите номер правильного ответа";
            // 
            // asnwer2RightButton
            // 
            this.asnwer2RightButton.AutoSize = true;
            this.asnwer2RightButton.Location = new System.Drawing.Point(777, 528);
            this.asnwer2RightButton.Name = "asnwer2RightButton";
            this.asnwer2RightButton.Size = new System.Drawing.Size(31, 17);
            this.asnwer2RightButton.TabIndex = 21;
            this.asnwer2RightButton.TabStop = true;
            this.asnwer2RightButton.Text = "2";
            this.asnwer2RightButton.UseVisualStyleBackColor = true;
            this.asnwer2RightButton.CheckedChanged += new System.EventHandler(this.asnwer2RightButton_CheckedChanged);
            // 
            // asnwer3RightButton
            // 
            this.asnwer3RightButton.AutoSize = true;
            this.asnwer3RightButton.Location = new System.Drawing.Point(999, 528);
            this.asnwer3RightButton.Name = "asnwer3RightButton";
            this.asnwer3RightButton.Size = new System.Drawing.Size(31, 17);
            this.asnwer3RightButton.TabIndex = 22;
            this.asnwer3RightButton.TabStop = true;
            this.asnwer3RightButton.Text = "3";
            this.asnwer3RightButton.UseVisualStyleBackColor = true;
            this.asnwer3RightButton.CheckedChanged += new System.EventHandler(this.asnwer3RightButton_CheckedChanged);
            // 
            // asnwer4RightButton
            // 
            this.asnwer4RightButton.AutoSize = true;
            this.asnwer4RightButton.Location = new System.Drawing.Point(1202, 528);
            this.asnwer4RightButton.Name = "asnwer4RightButton";
            this.asnwer4RightButton.Size = new System.Drawing.Size(31, 17);
            this.asnwer4RightButton.TabIndex = 23;
            this.asnwer4RightButton.TabStop = true;
            this.asnwer4RightButton.Text = "4";
            this.asnwer4RightButton.UseVisualStyleBackColor = true;
            this.asnwer4RightButton.CheckedChanged += new System.EventHandler(this.asnwer4RightButton_CheckedChanged);
            // 
            // saveQuestionButton
            // 
            this.saveQuestionButton.BackColor = System.Drawing.Color.White;
            this.saveQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveQuestionButton.Location = new System.Drawing.Point(535, 630);
            this.saveQuestionButton.Name = "saveQuestionButton";
            this.saveQuestionButton.Size = new System.Drawing.Size(698, 40);
            this.saveQuestionButton.TabIndex = 24;
            this.saveQuestionButton.Text = "Сохранить";
            this.saveQuestionButton.UseVisualStyleBackColor = false;
            this.saveQuestionButton.Click += new System.EventHandler(this.saveQuestionButton_Click);
            // 
            // deleteTestButton
            // 
            this.deleteTestButton.BackColor = System.Drawing.Color.White;
            this.deleteTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTestButton.Location = new System.Drawing.Point(1284, 91);
            this.deleteTestButton.Name = "deleteTestButton";
            this.deleteTestButton.Size = new System.Drawing.Size(39, 34);
            this.deleteTestButton.TabIndex = 25;
            this.deleteTestButton.Text = "-";
            this.deleteTestButton.UseVisualStyleBackColor = false;
            this.deleteTestButton.Click += new System.EventHandler(this.deleteTestButton_Click);
            // 
            // saveTestButton
            // 
            this.saveTestButton.BackColor = System.Drawing.Color.White;
            this.saveTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTestButton.Location = new System.Drawing.Point(1239, 143);
            this.saveTestButton.Name = "saveTestButton";
            this.saveTestButton.Size = new System.Drawing.Size(84, 33);
            this.saveTestButton.TabIndex = 26;
            this.saveTestButton.Text = "Сохранить";
            this.saveTestButton.UseVisualStyleBackColor = false;
            this.saveTestButton.Visible = false;
            this.saveTestButton.Click += new System.EventHandler(this.saveTestButton_Click);
            // 
            // newTestNameField
            // 
            this.newTestNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTestNameField.Location = new System.Drawing.Point(37, 145);
            this.newTestNameField.Name = "newTestNameField";
            this.newTestNameField.Size = new System.Drawing.Size(1196, 29);
            this.newTestNameField.TabIndex = 27;
            this.newTestNameField.Visible = false;
            // 
            // EditDataTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 731);
            this.Controls.Add(this.newTestNameField);
            this.Controls.Add(this.saveTestButton);
            this.Controls.Add(this.deleteTestButton);
            this.Controls.Add(this.saveQuestionButton);
            this.Controls.Add(this.asnwer4RightButton);
            this.Controls.Add(this.asnwer3RightButton);
            this.Controls.Add(this.asnwer2RightButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.asnwer1RightButton);
            this.Controls.Add(this.answer4Field);
            this.Controls.Add(this.answer3Field);
            this.Controls.Add(this.answer2Field);
            this.Controls.Add(this.answer1Field);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.questionNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.addNewTestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testsComboBox);
            this.Name = "EditDataTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDataTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addNewTestButton;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox answer1Field;
        private System.Windows.Forms.TextBox answer2Field;
        private System.Windows.Forms.TextBox answer3Field;
        private System.Windows.Forms.TextBox answer4Field;
        private System.Windows.Forms.RadioButton asnwer1RightButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton asnwer2RightButton;
        private System.Windows.Forms.RadioButton asnwer3RightButton;
        private System.Windows.Forms.RadioButton asnwer4RightButton;
        private System.Windows.Forms.Button saveQuestionButton;
        private System.Windows.Forms.Button deleteTestButton;
        private System.Windows.Forms.Button saveTestButton;
        private System.Windows.Forms.TextBox newTestNameField;
    }
}