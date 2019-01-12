namespace registration_app_winform
{
    partial class fmUserAddForm
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
            this.mcBirthDate = new System.Windows.Forms.MonthCalendar();
            this.gpSex = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gpDate = new System.Windows.Forms.GroupBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.gbPIB = new System.Windows.Forms.GroupBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.gpSex.SuspendLayout();
            this.gpDate.SuspendLayout();
            this.gbPIB.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcBirthDate
            // 
            this.mcBirthDate.Location = new System.Drawing.Point(19, 27);
            this.mcBirthDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.mcBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mcBirthDate.Name = "mcBirthDate";
            this.mcBirthDate.TabIndex = 2;
            this.mcBirthDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcBirthDate_DateChanged);
            // 
            // gpSex
            // 
            this.gpSex.Controls.Add(this.rbFemale);
            this.gpSex.Controls.Add(this.rbMale);
            this.gpSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpSex.Location = new System.Drawing.Point(372, 268);
            this.gpSex.Name = "gpSex";
            this.gpSex.Size = new System.Drawing.Size(200, 48);
            this.gpSex.TabIndex = 3;
            this.gpSex.TabStop = false;
            this.gpSex.Text = " Стать ";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMale.Location = new System.Drawing.Point(14, 19);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(97, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Чоловіча";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbFemale.Location = new System.Drawing.Point(118, 20);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(79, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Жіноча";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gpDate
            // 
            this.gpDate.Controls.Add(this.txtBirthDate);
            this.gpDate.Controls.Add(this.mcBirthDate);
            this.gpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpDate.Location = new System.Drawing.Point(372, 14);
            this.gpDate.Name = "gpDate";
            this.gpDate.Size = new System.Drawing.Size(200, 240);
            this.gpDate.TabIndex = 4;
            this.gpDate.TabStop = false;
            this.gpDate.Text = " Дата народження ";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(20, 199);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(162, 26);
            this.txtBirthDate.TabIndex = 3;
            // 
            // gbPIB
            // 
            this.gbPIB.Controls.Add(this.txtSecondName);
            this.gbPIB.Controls.Add(this.txtName);
            this.gbPIB.Controls.Add(this.txtLastName);
            this.gbPIB.Controls.Add(this.lbSecondName);
            this.gbPIB.Controls.Add(this.lbName);
            this.gbPIB.Controls.Add(this.lbLastName);
            this.gbPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPIB.Location = new System.Drawing.Point(16, 14);
            this.gbPIB.Name = "gbPIB";
            this.gbPIB.Size = new System.Drawing.Size(339, 147);
            this.gbPIB.TabIndex = 5;
            this.gbPIB.TabStop = false;
            this.gbPIB.Text = " ПІБ ";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondName.Location = new System.Drawing.Point(116, 112);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(214, 26);
            this.txtSecondName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(116, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(116, 24);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(214, 26);
            this.txtLastName.TabIndex = 7;
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSecondName.Location = new System.Drawing.Point(3, 115);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(110, 20);
            this.lbSecondName.TabIndex = 2;
            this.lbSecondName.Text = "По батькові";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(3, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Ім\'я";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastName.Location = new System.Drawing.Point(3, 27);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(89, 20);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Прізвище";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtPassword);
            this.gbData.Controls.Add(this.txtPhone);
            this.gbData.Controls.Add(this.txtEmail);
            this.gbData.Controls.Add(this.lbPass);
            this.gbData.Controls.Add(this.lbPhone);
            this.gbData.Controls.Add(this.lbEmail);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbData.Location = new System.Drawing.Point(16, 182);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(339, 135);
            this.gbData.TabIndex = 6;
            this.gbData.TabStop = false;
            this.gbData.Text = " Контактні дані ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(118, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(118, 31);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(118, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(6, 99);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(73, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Пароль";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(6, 32);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(86, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Телефон";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(7, 65);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(84, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Е-Пошта";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(417, 326);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(155, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(252, 326);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(156, 23);
            this.btAddUser.TabIndex = 7;
            this.btAddUser.Text = "Додати користувача";
            this.btAddUser.UseVisualStyleBackColor = true;
            // 
            // fmUserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbPIB);
            this.Controls.Add(this.gpDate);
            this.Controls.Add(this.gpSex);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "fmUserAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма для додавання нового користувача";
            this.gpSex.ResumeLayout(false);
            this.gpSex.PerformLayout();
            this.gpDate.ResumeLayout(false);
            this.gpDate.PerformLayout();
            this.gbPIB.ResumeLayout(false);
            this.gbPIB.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar mcBirthDate;
        private System.Windows.Forms.GroupBox gpSex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gpDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.GroupBox gbPIB;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAddUser;
    }
}