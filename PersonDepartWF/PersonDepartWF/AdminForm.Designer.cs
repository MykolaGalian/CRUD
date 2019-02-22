namespace PersonDepartWF
{
    partial class AdminForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmployeePassword = new System.Windows.Forms.TextBox();
            this.tbEmployeeLogin = new System.Windows.Forms.TextBox();
            this.tbEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalPerson = new System.Windows.Forms.Label();
            this.lbEmployees_nonUsers = new System.Windows.Forms.ListBox();
            this.lbUsers_user = new System.Windows.Forms.ListBox();
            this.lbUsers_admin = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbEmployeeTypeOfUser = new System.Windows.Forms.ComboBox();
            this.lableTypeOfUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(739, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(552, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Зберегти зміни";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbEmployeePassword
            // 
            this.tbEmployeePassword.Location = new System.Drawing.Point(656, 183);
            this.tbEmployeePassword.Name = "tbEmployeePassword";
            this.tbEmployeePassword.Size = new System.Drawing.Size(165, 20);
            this.tbEmployeePassword.TabIndex = 17;
            // 
            // tbEmployeeLogin
            // 
            this.tbEmployeeLogin.Location = new System.Drawing.Point(656, 157);
            this.tbEmployeeLogin.Name = "tbEmployeeLogin";
            this.tbEmployeeLogin.Size = new System.Drawing.Size(165, 20);
            this.tbEmployeeLogin.TabIndex = 19;
            // 
            // tbEmployeeLastName
            // 
            this.tbEmployeeLastName.Location = new System.Drawing.Point(656, 72);
            this.tbEmployeeLastName.Name = "tbEmployeeLastName";
            this.tbEmployeeLastName.ReadOnly = true;
            this.tbEmployeeLastName.Size = new System.Drawing.Size(165, 20);
            this.tbEmployeeLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прізвище:";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(656, 46);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.ReadOnly = true;
            this.tbEmployeeName.Size = new System.Drawing.Size(165, 20);
            this.tbEmployeeName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(333, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Керування користувачами";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логін:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Тип облікового запису:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(750, 346);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 28;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Кількість адміністраторів:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Кількість звичайних користувачів:";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(791, 290);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(35, 13);
            this.labelAdmin.TabIndex = 30;
            this.labelAdmin.Text = "admin";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(791, 307);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(27, 13);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "user";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Загальна кількість зареєстрованих осіб:";
            // 
            // labelTotalPerson
            // 
            this.labelTotalPerson.AutoSize = true;
            this.labelTotalPerson.Location = new System.Drawing.Point(791, 326);
            this.labelTotalPerson.Name = "labelTotalPerson";
            this.labelTotalPerson.Size = new System.Drawing.Size(27, 13);
            this.labelTotalPerson.TabIndex = 30;
            this.labelTotalPerson.Text = "total";
            // 
            // lbEmployees_nonUsers
            // 
            this.lbEmployees_nonUsers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEmployees_nonUsers.FormattingEnabled = true;
            this.lbEmployees_nonUsers.Location = new System.Drawing.Point(7, 35);
            this.lbEmployees_nonUsers.Name = "lbEmployees_nonUsers";
            this.lbEmployees_nonUsers.Size = new System.Drawing.Size(158, 290);
            this.lbEmployees_nonUsers.TabIndex = 32;
            this.lbEmployees_nonUsers.DoubleClick += new System.EventHandler(this.lbEmployees_nonUsers_DoubleClick);
            // 
            // lbUsers_user
            // 
            this.lbUsers_user.FormattingEnabled = true;
            this.lbUsers_user.Location = new System.Drawing.Point(6, 33);
            this.lbUsers_user.Name = "lbUsers_user";
            this.lbUsers_user.Size = new System.Drawing.Size(158, 290);
            this.lbUsers_user.TabIndex = 32;
            this.lbUsers_user.DoubleClick += new System.EventHandler(this.lbUsers_user_DoubleClick);
            // 
            // lbUsers_admin
            // 
            this.lbUsers_admin.FormattingEnabled = true;
            this.lbUsers_admin.Location = new System.Drawing.Point(7, 35);
            this.lbUsers_admin.Name = "lbUsers_admin";
            this.lbUsers_admin.Size = new System.Drawing.Size(158, 290);
            this.lbUsers_admin.TabIndex = 32;
            this.lbUsers_admin.DoubleClick += new System.EventHandler(this.lbUsers_admin_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lbUsers_admin);
            this.groupBox1.Location = new System.Drawing.Point(356, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 333);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список адміністраторів програми";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lbEmployees_nonUsers);
            this.groupBox2.Location = new System.Drawing.Point(8, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 333);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список співробітників (без доступу до програми)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.lbUsers_user);
            this.groupBox3.Location = new System.Drawing.Point(182, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 333);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список користувачів програми";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(656, 98);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(165, 20);
            this.tbPosition.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Відділ:";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(656, 123);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.ReadOnly = true;
            this.tbDepartment.Size = new System.Drawing.Size(165, 20);
            this.tbDepartment.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(540, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(280, 2);
            this.label18.TabIndex = 42;
            // 
            // cbEmployeeTypeOfUser
            // 
            this.cbEmployeeTypeOfUser.FormattingEnabled = true;
            this.cbEmployeeTypeOfUser.Items.AddRange(new object[] {
            "Admin",
            "User",
            "NULL"});
            this.cbEmployeeTypeOfUser.Location = new System.Drawing.Point(656, 211);
            this.cbEmployeeTypeOfUser.Name = "cbEmployeeTypeOfUser";
            this.cbEmployeeTypeOfUser.Size = new System.Drawing.Size(165, 21);
            this.cbEmployeeTypeOfUser.TabIndex = 43;
            this.cbEmployeeTypeOfUser.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeTypeOfUser_SelectedIndexChanged);
            // 
            // lableTypeOfUser
            // 
            this.lableTypeOfUser.AutoSize = true;
            this.lableTypeOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableTypeOfUser.Location = new System.Drawing.Point(675, 27);
            this.lableTypeOfUser.Name = "lableTypeOfUser";
            this.lableTypeOfUser.Size = new System.Drawing.Size(143, 13);
            this.lableTypeOfUser.TabIndex = 44;
            this.lableTypeOfUser.Text = "Тип облікового запису";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Вхід";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Посада:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lableTypeOfUser);
            this.Controls.Add(this.cbEmployeeTypeOfUser);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelTotalPerson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbEmployeePassword);
            this.Controls.Add(this.tbEmployeeLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmployeeLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Керування користувачами";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbEmployeePassword;
        private System.Windows.Forms.TextBox tbEmployeeLogin;
        private System.Windows.Forms.TextBox tbEmployeeLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalPerson;
        private System.Windows.Forms.ListBox lbEmployees_nonUsers;
        private System.Windows.Forms.ListBox lbUsers_user;
        private System.Windows.Forms.ListBox lbUsers_admin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbEmployeeTypeOfUser;
        private System.Windows.Forms.Label lableTypeOfUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}