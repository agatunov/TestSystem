
namespace TestSystem
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.answer1Button = new System.Windows.Forms.RadioButton();
            this.answer2Button = new System.Windows.Forms.RadioButton();
            this.answer3Button = new System.Windows.Forms.RadioButton();
            this.answer4Button = new System.Windows.Forms.RadioButton();
            this.questionField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeQuestionLabel = new System.Windows.Forms.Label();
            this.timeTestLabel = new System.Windows.Forms.Label();
            this.toAnswerButton = new System.Windows.Forms.Button();
            this.toCompleteButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(394, 22);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(258, 25);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Ваше Ф.И.О: placeholder";
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNameLabel.Location = new System.Drawing.Point(433, 69);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(170, 25);
            this.testNameLabel.TabIndex = 1;
            this.testNameLabel.Text = "Название теста";
            // 
            // answer1Button
            // 
            this.answer1Button.AutoSize = true;
            this.answer1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1Button.Location = new System.Drawing.Point(12, 377);
            this.answer1Button.Name = "answer1Button";
            this.answer1Button.Size = new System.Drawing.Size(133, 28);
            this.answer1Button.TabIndex = 3;
            this.answer1Button.TabStop = true;
            this.answer1Button.Text = "radioButton1";
            this.answer1Button.UseVisualStyleBackColor = true;
            // 
            // answer2Button
            // 
            this.answer2Button.AutoSize = true;
            this.answer2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2Button.Location = new System.Drawing.Point(12, 423);
            this.answer2Button.Name = "answer2Button";
            this.answer2Button.Size = new System.Drawing.Size(133, 28);
            this.answer2Button.TabIndex = 4;
            this.answer2Button.TabStop = true;
            this.answer2Button.Text = "radioButton2";
            this.answer2Button.UseVisualStyleBackColor = true;
            // 
            // answer3Button
            // 
            this.answer3Button.AutoSize = true;
            this.answer3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3Button.Location = new System.Drawing.Point(12, 472);
            this.answer3Button.Name = "answer3Button";
            this.answer3Button.Size = new System.Drawing.Size(133, 28);
            this.answer3Button.TabIndex = 5;
            this.answer3Button.TabStop = true;
            this.answer3Button.Text = "radioButton3";
            this.answer3Button.UseVisualStyleBackColor = true;
            // 
            // answer4Button
            // 
            this.answer4Button.AutoSize = true;
            this.answer4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer4Button.Location = new System.Drawing.Point(12, 523);
            this.answer4Button.Name = "answer4Button";
            this.answer4Button.Size = new System.Drawing.Size(133, 28);
            this.answer4Button.TabIndex = 6;
            this.answer4Button.TabStop = true;
            this.answer4Button.Text = "radioButton4";
            this.answer4Button.UseVisualStyleBackColor = true;
            // 
            // questionField
            // 
            this.questionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionField.Location = new System.Drawing.Point(12, 172);
            this.questionField.Multiline = true;
            this.questionField.Name = "questionField";
            this.questionField.Size = new System.Drawing.Size(1007, 188);
            this.questionField.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вопрос:";
            // 
            // timeQuestionLabel
            // 
            this.timeQuestionLabel.AutoSize = true;
            this.timeQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeQuestionLabel.Location = new System.Drawing.Point(12, 580);
            this.timeQuestionLabel.Name = "timeQuestionLabel";
            this.timeQuestionLabel.Size = new System.Drawing.Size(294, 25);
            this.timeQuestionLabel.TabIndex = 9;
            this.timeQuestionLabel.Text = "Времени на данный вопрос:";
            // 
            // timeTestLabel
            // 
            this.timeTestLabel.AutoSize = true;
            this.timeTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTestLabel.Location = new System.Drawing.Point(12, 640);
            this.timeTestLabel.Name = "timeTestLabel";
            this.timeTestLabel.Size = new System.Drawing.Size(237, 25);
            this.timeTestLabel.TabIndex = 10;
            this.timeTestLabel.Text = "Времени на весь тест:";
            // 
            // toAnswerButton
            // 
            this.toAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toAnswerButton.Location = new System.Drawing.Point(229, 716);
            this.toAnswerButton.Name = "toAnswerButton";
            this.toAnswerButton.Size = new System.Drawing.Size(214, 46);
            this.toAnswerButton.TabIndex = 12;
            this.toAnswerButton.Text = "Ответить";
            this.toAnswerButton.UseVisualStyleBackColor = true;
            this.toAnswerButton.Click += new System.EventHandler(this.toAnswerButton_Click);
            // 
            // toCompleteButton
            // 
            this.toCompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCompleteButton.Location = new System.Drawing.Point(508, 716);
            this.toCompleteButton.Name = "toCompleteButton";
            this.toCompleteButton.Size = new System.Drawing.Size(214, 46);
            this.toCompleteButton.TabIndex = 13;
            this.toCompleteButton.Text = "Завершить тест";
            this.toCompleteButton.UseVisualStyleBackColor = true;
            this.toCompleteButton.Click += new System.EventHandler(this.toCompleteButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 799);
            this.Controls.Add(this.toCompleteButton);
            this.Controls.Add(this.toAnswerButton);
            this.Controls.Add(this.timeTestLabel);
            this.Controls.Add(this.timeQuestionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionField);
            this.Controls.Add(this.answer4Button);
            this.Controls.Add(this.answer3Button);
            this.Controls.Add(this.answer2Button);
            this.Controls.Add(this.answer1Button);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.RadioButton answer1Button;
        private System.Windows.Forms.RadioButton answer2Button;
        private System.Windows.Forms.RadioButton answer3Button;
        private System.Windows.Forms.RadioButton answer4Button;
        private System.Windows.Forms.TextBox questionField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeQuestionLabel;
        private System.Windows.Forms.Label timeTestLabel;
        private System.Windows.Forms.Button toAnswerButton;
        private System.Windows.Forms.Button toCompleteButton;
        private System.Windows.Forms.Timer timer;
    }
}