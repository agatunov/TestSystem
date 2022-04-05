
namespace TestSystem
{
    partial class ControlPanelAdminForm
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
            this.editDataUserBtn = new System.Windows.Forms.Button();
            this.editDataTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editDataUserBtn
            // 
            this.editDataUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDataUserBtn.Location = new System.Drawing.Point(48, 55);
            this.editDataUserBtn.Name = "editDataUserBtn";
            this.editDataUserBtn.Size = new System.Drawing.Size(495, 55);
            this.editDataUserBtn.TabIndex = 16;
            this.editDataUserBtn.Text = "Изменение данных о пользователях";
            this.editDataUserBtn.UseVisualStyleBackColor = true;
            // 
            // editDataTestBtn
            // 
            this.editDataTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDataTestBtn.Location = new System.Drawing.Point(48, 137);
            this.editDataTestBtn.Name = "editDataTestBtn";
            this.editDataTestBtn.Size = new System.Drawing.Size(495, 55);
            this.editDataTestBtn.TabIndex = 17;
            this.editDataTestBtn.Text = "Редактирование базы данных";
            this.editDataTestBtn.UseVisualStyleBackColor = true;
            this.editDataTestBtn.Click += new System.EventHandler(this.editDataTestBtn_Click);
            // 
            // ControlPanelAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 235);
            this.Controls.Add(this.editDataTestBtn);
            this.Controls.Add(this.editDataUserBtn);
            this.Name = "ControlPanelAdminForm";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editDataUserBtn;
        private System.Windows.Forms.Button editDataTestBtn;
    }
}