namespace registration_app_winform
{
    partial class fmUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmUserForm));
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.gbPass = new System.Windows.Forms.GroupBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btChangePass = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbFullNameInfo = new System.Windows.Forms.Label();
            this.lbBirthInfo = new System.Windows.Forms.Label();
            this.lbPhoneInfo = new System.Windows.Forms.Label();
            this.lbSexInfo = new System.Windows.Forms.Label();
            this.lbRoleInfo = new System.Windows.Forms.Label();
            this.lbStatusInfo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbEmailInfo = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.chShowPass = new System.Windows.Forms.CheckBox();
            this.gbPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFullname.Location = new System.Drawing.Point(12, 8);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(41, 20);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "ПІБ:";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBirth.Location = new System.Drawing.Point(12, 58);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(150, 20);
            this.lbBirth.TabIndex = 1;
            this.lbBirth.Text = "День народження:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(12, 84);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(83, 20);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Телефон:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSex.Location = new System.Drawing.Point(12, 108);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(60, 20);
            this.lbSex.TabIndex = 2;
            this.lbSex.Text = "Стать:";
            // 
            // gbPass
            // 
            this.gbPass.Controls.Add(this.chShowPass);
            this.gbPass.Controls.Add(this.txtNewPass);
            this.gbPass.Controls.Add(this.lbNewPass);
            this.gbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPass.Location = new System.Drawing.Point(15, 197);
            this.gbPass.Name = "gbPass";
            this.gbPass.Size = new System.Drawing.Size(420, 99);
            this.gbPass.TabIndex = 3;
            this.gbPass.TabStop = false;
            this.gbPass.Text = " Змінити пароль ";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRole.Location = new System.Drawing.Point(12, 132);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(51, 20);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Роль:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.Location = new System.Drawing.Point(12, 156);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(66, 20);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Статус:";
            // 
            // btChangePass
            // 
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChangePass.Location = new System.Drawing.Point(142, 302);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(152, 30);
            this.btChangePass.TabIndex = 6;
            this.btChangePass.Text = "Змінити пароль";
            this.btChangePass.UseVisualStyleBackColor = true;
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(312, 302);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(123, 30);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbFullNameInfo
            // 
            this.lbFullNameInfo.AutoSize = true;
            this.lbFullNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFullNameInfo.Location = new System.Drawing.Point(180, 8);
            this.lbFullNameInfo.Name = "lbFullNameInfo";
            this.lbFullNameInfo.Size = new System.Drawing.Size(15, 20);
            this.lbFullNameInfo.TabIndex = 0;
            this.lbFullNameInfo.Text = "-";
            // 
            // lbBirthInfo
            // 
            this.lbBirthInfo.AutoSize = true;
            this.lbBirthInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBirthInfo.Location = new System.Drawing.Point(180, 58);
            this.lbBirthInfo.Name = "lbBirthInfo";
            this.lbBirthInfo.Size = new System.Drawing.Size(15, 20);
            this.lbBirthInfo.TabIndex = 1;
            this.lbBirthInfo.Text = "-";
            // 
            // lbPhoneInfo
            // 
            this.lbPhoneInfo.AutoSize = true;
            this.lbPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhoneInfo.Location = new System.Drawing.Point(180, 84);
            this.lbPhoneInfo.Name = "lbPhoneInfo";
            this.lbPhoneInfo.Size = new System.Drawing.Size(15, 20);
            this.lbPhoneInfo.TabIndex = 1;
            this.lbPhoneInfo.Text = "-";
            // 
            // lbSexInfo
            // 
            this.lbSexInfo.AutoSize = true;
            this.lbSexInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSexInfo.Location = new System.Drawing.Point(180, 108);
            this.lbSexInfo.Name = "lbSexInfo";
            this.lbSexInfo.Size = new System.Drawing.Size(15, 20);
            this.lbSexInfo.TabIndex = 2;
            this.lbSexInfo.Text = "-";
            // 
            // lbRoleInfo
            // 
            this.lbRoleInfo.AutoSize = true;
            this.lbRoleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoleInfo.Location = new System.Drawing.Point(180, 132);
            this.lbRoleInfo.Name = "lbRoleInfo";
            this.lbRoleInfo.Size = new System.Drawing.Size(15, 20);
            this.lbRoleInfo.TabIndex = 4;
            this.lbRoleInfo.Text = "-";
            // 
            // lbStatusInfo
            // 
            this.lbStatusInfo.AutoSize = true;
            this.lbStatusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatusInfo.Location = new System.Drawing.Point(180, 156);
            this.lbStatusInfo.Name = "lbStatusInfo";
            this.lbStatusInfo.Size = new System.Drawing.Size(15, 20);
            this.lbStatusInfo.TabIndex = 5;
            this.lbStatusInfo.Text = "-";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.Location = new System.Drawing.Point(12, 32);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email:";
            // 
            // lbEmailInfo
            // 
            this.lbEmailInfo.AutoSize = true;
            this.lbEmailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmailInfo.Location = new System.Drawing.Point(180, 32);
            this.lbEmailInfo.Name = "lbEmailInfo";
            this.lbEmailInfo.Size = new System.Drawing.Size(15, 20);
            this.lbEmailInfo.TabIndex = 9;
            this.lbEmailInfo.Text = "-";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(10, 33);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(116, 20);
            this.lbNewPass.TabIndex = 0;
            this.lbNewPass.Text = "Новий пароль";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(160, 32);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(245, 26);
            this.txtNewPass.TabIndex = 1;
            // 
            // chShowPass
            // 
            this.chShowPass.AutoSize = true;
            this.chShowPass.Location = new System.Drawing.Point(160, 64);
            this.chShowPass.Name = "chShowPass";
            this.chShowPass.Size = new System.Drawing.Size(160, 24);
            this.chShowPass.TabIndex = 2;
            this.chShowPass.Text = "Показати пароль";
            this.chShowPass.UseVisualStyleBackColor = true;
            this.chShowPass.CheckedChanged += new System.EventHandler(this.chShowPass_CheckedChanged);
            // 
            // fmUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.lbEmailInfo);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.lbStatusInfo);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbRoleInfo);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.gbPass);
            this.Controls.Add(this.lbSexInfo);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbPhoneInfo);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbBirthInfo);
            this.Controls.Add(this.lbBirth);
            this.Controls.Add(this.lbFullNameInfo);
            this.Controls.Add(this.lbFullname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація про користувача";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmUserForm_FormClosed);
            this.Load += new System.EventHandler(this.fmUserForm_Load);
            this.gbPass.ResumeLayout(false);
            this.gbPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.GroupBox gbPass;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbFullNameInfo;
        private System.Windows.Forms.Label lbBirthInfo;
        private System.Windows.Forms.Label lbPhoneInfo;
        private System.Windows.Forms.Label lbSexInfo;
        private System.Windows.Forms.Label lbRoleInfo;
        private System.Windows.Forms.Label lbStatusInfo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbEmailInfo;
        private System.Windows.Forms.CheckBox chShowPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbNewPass;
    }
}