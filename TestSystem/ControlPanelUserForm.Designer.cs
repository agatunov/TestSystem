
namespace TestSystem
{
    partial class ControlPanelUserForm
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
            this.AuthorizationHeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginFieldLabel = new System.Windows.Forms.Label();
            this.fullnameFieldLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.passBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.testHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getCertificateBtn = new System.Windows.Forms.Button();
            this.editDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorizationHeaderLabel
            // 
            this.AuthorizationHeaderLabel.AutoSize = true;
            this.AuthorizationHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationHeaderLabel.Location = new System.Drawing.Point(448, 25);
            this.AuthorizationHeaderLabel.Name = "AuthorizationHeaderLabel";
            this.AuthorizationHeaderLabel.Size = new System.Drawing.Size(280, 31);
            this.AuthorizationHeaderLabel.TabIndex = 2;
            this.AuthorizationHeaderLabel.Text = "Панель управления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(758, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваш логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(747, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ваше Ф.И.О:";
            // 
            // loginFieldLabel
            // 
            this.loginFieldLabel.AutoSize = true;
            this.loginFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginFieldLabel.Location = new System.Drawing.Point(872, 84);
            this.loginFieldLabel.Name = "loginFieldLabel";
            this.loginFieldLabel.Size = new System.Drawing.Size(155, 24);
            this.loginFieldLabel.TabIndex = 5;
            this.loginFieldLabel.Text = "loginPlaceHolder";
            // 
            // fullnameFieldLabel
            // 
            this.fullnameFieldLabel.AutoSize = true;
            this.fullnameFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullnameFieldLabel.Location = new System.Drawing.Point(872, 125);
            this.fullnameFieldLabel.Name = "fullnameFieldLabel";
            this.fullnameFieldLabel.Size = new System.Drawing.Size(188, 24);
            this.fullnameFieldLabel.TabIndex = 6;
            this.fullnameFieldLabel.Text = "fullNamePlaceHolder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(501, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите тест:";
            // 
            // testsComboBox
            // 
            this.testsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(44, 222);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(1055, 32);
            this.testsComboBox.TabIndex = 8;
            // 
            // passBtn
            // 
            this.passBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBtn.Location = new System.Drawing.Point(479, 260);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(204, 33);
            this.passBtn.TabIndex = 11;
            this.passBtn.Text = "Пройти";
            this.passBtn.UseVisualStyleBackColor = true;
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshBtn.Location = new System.Drawing.Point(479, 311);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(204, 33);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Обновить историю";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // testHistoryDataGrid
            // 
            this.testHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestName,
            this.Result,
            this.TestTime,
            this.CountPoints,
            this.DateTest});
            this.testHistoryDataGrid.Location = new System.Drawing.Point(54, 360);
            this.testHistoryDataGrid.Name = "testHistoryDataGrid";
            this.testHistoryDataGrid.Size = new System.Drawing.Size(1045, 324);
            this.testHistoryDataGrid.TabIndex = 13;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Название теста";
            this.TestName.Name = "TestName";
            this.TestName.Width = 400;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.Width = 300;
            // 
            // TestTime
            // 
            this.TestTime.HeaderText = "Затраченное время";
            this.TestTime.Name = "TestTime";
            // 
            // CountPoints
            // 
            this.CountPoints.HeaderText = "Количество баллов";
            this.CountPoints.Name = "CountPoints";
            // 
            // DateTest
            // 
            this.DateTest.HeaderText = "Дата";
            this.DateTest.Name = "DateTest";
            // 
            // getCertificateBtn
            // 
            this.getCertificateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCertificateBtn.Location = new System.Drawing.Point(479, 699);
            this.getCertificateBtn.Name = "getCertificateBtn";
            this.getCertificateBtn.Size = new System.Drawing.Size(204, 33);
            this.getCertificateBtn.TabIndex = 14;
            this.getCertificateBtn.Text = "Сертификат";
            this.getCertificateBtn.UseVisualStyleBackColor = true;
            // 
            // editDataBtn
            // 
            this.editDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDataBtn.Location = new System.Drawing.Point(751, 152);
            this.editDataBtn.Name = "editDataBtn";
            this.editDataBtn.Size = new System.Drawing.Size(297, 33);
            this.editDataBtn.TabIndex = 15;
            this.editDataBtn.Text = "Изменить данные";
            this.editDataBtn.UseVisualStyleBackColor = true;
            this.editDataBtn.Click += new System.EventHandler(this.editDataBtn_Click);
            // 
            // ControlPanelUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 753);
            this.Controls.Add(this.editDataBtn);
            this.Controls.Add(this.getCertificateBtn);
            this.Controls.Add(this.testHistoryDataGrid);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.testsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullnameFieldLabel);
            this.Controls.Add(this.loginFieldLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorizationHeaderLabel);
            this.Name = "ControlPanelUserForm";
            this.Text = "Панель управления пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorizationHeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginFieldLabel;
        private System.Windows.Forms.Label fullnameFieldLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView testHistoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTest;
        private System.Windows.Forms.Button getCertificateBtn;
        private System.Windows.Forms.Button editDataBtn;
    }
}