﻿namespace registration_app_winform
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.dvgUsers = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUsers
            // 
            this.dvgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnFullName,
            this.ColumnEmail,
            this.ColumnPhone,
            this.ColumnRole,
            this.ColumnAge,
            this.ColumnSex});
            this.dvgUsers.Location = new System.Drawing.Point(13, 48);
            this.dvgUsers.Name = "dvgUsers";
            this.dvgUsers.Size = new System.Drawing.Size(825, 432);
            this.dvgUsers.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFullName.HeaderText = "ПІБ";
            this.ColumnFullName.Name = "ColumnFullName";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Е-пошта";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 200;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 120;
            // 
            // ColumnRole
            // 
            this.ColumnRole.HeaderText = "Роль";
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.Width = 50;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Вік";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.Width = 50;
            // 
            // ColumnSex
            // 
            this.ColumnSex.HeaderText = "Стать";
            this.ColumnSex.Name = "ColumnSex";
            this.ColumnSex.Width = 75;
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(13, 10);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(161, 23);
            this.btAddUser.TabIndex = 2;
            this.btAddUser.Text = "Додати користувача";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btChange
            // 
            this.btChange.Enabled = false;
            this.btChange.Location = new System.Drawing.Point(192, 10);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(176, 23);
            this.btChange.TabIndex = 3;
            this.btChange.Text = "Змінити статус користувача";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 492);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.dvgUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма для роботи з даними користувачів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMain_FormClosed);
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgUsers;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSex;
        private System.Windows.Forms.Button btChange;
    }
}

