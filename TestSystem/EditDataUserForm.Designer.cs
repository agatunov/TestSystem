
namespace TestSystem
{
    partial class EditDataUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.password2Field = new System.Windows.Forms.TextBox();
            this.editDataBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ф.И.О:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль ещё раз:";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(186, 109);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(587, 29);
            this.loginField.TabIndex = 8;
            // 
            // fullNameField
            // 
            this.fullNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameField.Location = new System.Drawing.Point(186, 155);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(587, 29);
            this.fullNameField.TabIndex = 9;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(186, 200);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(587, 29);
            this.passwordField.TabIndex = 10;
            // 
            // password2Field
            // 
            this.password2Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2Field.Location = new System.Drawing.Point(186, 244);
            this.password2Field.Name = "password2Field";
            this.password2Field.Size = new System.Drawing.Size(587, 29);
            this.password2Field.TabIndex = 11;
            // 
            // editDataBtn
            // 
            this.editDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDataBtn.Location = new System.Drawing.Point(129, 312);
            this.editDataBtn.Name = "editDataBtn";
            this.editDataBtn.Size = new System.Drawing.Size(331, 33);
            this.editDataBtn.TabIndex = 12;
            this.editDataBtn.Text = "Изменить данные";
            this.editDataBtn.UseVisualStyleBackColor = true;
            this.editDataBtn.Click += new System.EventHandler(this.editDataBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(517, 312);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(256, 33);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // EditDataUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 461);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editDataBtn);
            this.Controls.Add(this.password2Field);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.fullNameField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditDataUserForm";
            this.Text = "Редактирование данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox fullNameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox password2Field;
        private System.Windows.Forms.Button editDataBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}