namespace PersonDepartWF
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDepartList = new System.Windows.Forms.ListBox();
            this.lbPositionList = new System.Windows.Forms.ListBox();
            this.lbEmployeeList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMaxNumberEmp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMaxNumberEmp = new System.Windows.Forms.ComboBox();
            this.cbPosNameForDep = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCurrentNumEmp = new System.Windows.Forms.TextBox();
            this.btAddPosInDep = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btSaveMaxNumberInPos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Адреса:";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(307, 78);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(163, 20);
            this.tbAdress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Електронна адреса:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(307, 104);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(163, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата народження:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Заробітня плата, тис.грн.:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(307, 156);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(163, 20);
            this.tbSalary.TabIndex = 2;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(307, 52);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(163, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(307, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(163, 20);
            this.tbName.TabIndex = 2;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = "dd.MM.yyyy";
            this.dtpDateBirth.Location = new System.Drawing.Point(307, 130);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(163, 20);
            this.dtpDateBirth.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(169, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 2);
            this.label12.TabIndex = 12;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "dd.MM.yyyy";
            this.dtpHireDate.Location = new System.Drawing.Point(307, 183);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(163, 20);
            this.dtpHireDate.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(850, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Дата прийняття на роботу:";
            // 
            // lbDepartList
            // 
            this.lbDepartList.FormattingEnabled = true;
            this.lbDepartList.Location = new System.Drawing.Point(10, 19);
            this.lbDepartList.Name = "lbDepartList";
            this.lbDepartList.Size = new System.Drawing.Size(396, 121);
            this.lbDepartList.TabIndex = 14;
            this.lbDepartList.DoubleClick += new System.EventHandler(this.lbDepartList_DoubleClick);
            // 
            // lbPositionList
            // 
            this.lbPositionList.FormattingEnabled = true;
            this.lbPositionList.Location = new System.Drawing.Point(6, 21);
            this.lbPositionList.Name = "lbPositionList";
            this.lbPositionList.Size = new System.Drawing.Size(160, 225);
            this.lbPositionList.TabIndex = 15;
            this.lbPositionList.DoubleClick += new System.EventHandler(this.lbPositionList_DoubleClick);
            // 
            // lbEmployeeList
            // 
            this.lbEmployeeList.FormattingEnabled = true;
            this.lbEmployeeList.Location = new System.Drawing.Point(11, 19);
            this.lbEmployeeList.Name = "lbEmployeeList";
            this.lbEmployeeList.Size = new System.Drawing.Size(138, 355);
            this.lbEmployeeList.TabIndex = 16;
            this.lbEmployeeList.DoubleClick += new System.EventHandler(this.lbEmployeeList_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbEmployeeList);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAdress);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.dtpHireDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpDateBirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(453, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 388);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Співробітники відділу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Прізвище:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ім\'я:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tbMaxNumberEmp);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbMaxNumberEmp);
            this.groupBox2.Controls.Add(this.cbPosNameForDep);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbCurrentNumEmp);
            this.groupBox2.Controls.Add(this.btAddPosInDep);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbPositionList);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btSaveMaxNumberInPos);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 261);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список посад у відділі";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(176, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 2);
            this.label18.TabIndex = 28;
            // 
            // tbMaxNumberEmp
            // 
            this.tbMaxNumberEmp.Location = new System.Drawing.Point(383, 189);
            this.tbMaxNumberEmp.Name = "tbMaxNumberEmp";
            this.tbMaxNumberEmp.ReadOnly = true;
            this.tbMaxNumberEmp.Size = new System.Drawing.Size(23, 20);
            this.tbMaxNumberEmp.TabIndex = 26;
            this.tbMaxNumberEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(174, 185);
            this.label17.MaximumSize = new System.Drawing.Size(240, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(211, 26);
            this.label17.TabIndex = 27;
            this.label17.Text = "Кількість працівників на даній посаді за штатним розкладом:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMaxNumberEmp
            // 
            this.cbMaxNumberEmp.FormattingEnabled = true;
            this.cbMaxNumberEmp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbMaxNumberEmp.Location = new System.Drawing.Point(178, 88);
            this.cbMaxNumberEmp.Name = "cbMaxNumberEmp";
            this.cbMaxNumberEmp.Size = new System.Drawing.Size(161, 21);
            this.cbMaxNumberEmp.TabIndex = 25;
            this.cbMaxNumberEmp.SelectedIndexChanged += new System.EventHandler(this.cbMaxNumberEmp_SelectedIndexChanged);
            // 
            // cbPosNameForDep
            // 
            this.cbPosNameForDep.FormattingEnabled = true;
            this.cbPosNameForDep.Location = new System.Drawing.Point(176, 31);
            this.cbPosNameForDep.Name = "cbPosNameForDep";
            this.cbPosNameForDep.Size = new System.Drawing.Size(163, 21);
            this.cbPosNameForDep.TabIndex = 24;
            this.cbPosNameForDep.SelectedIndexChanged += new System.EventHandler(this.cbPosNameForDep_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 58);
            this.label13.MaximumSize = new System.Drawing.Size(260, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 26);
            this.label13.TabIndex = 17;
            this.label13.Text = "Задати кількість співробітників для обраної посади за штатним розкладом:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCurrentNumEmp
            // 
            this.tbCurrentNumEmp.Location = new System.Drawing.Point(383, 226);
            this.tbCurrentNumEmp.Name = "tbCurrentNumEmp";
            this.tbCurrentNumEmp.ReadOnly = true;
            this.tbCurrentNumEmp.Size = new System.Drawing.Size(23, 20);
            this.tbCurrentNumEmp.TabIndex = 22;
            this.tbCurrentNumEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAddPosInDep
            // 
            this.btAddPosInDep.Location = new System.Drawing.Point(177, 116);
            this.btAddPosInDep.Name = "btAddPosInDep";
            this.btAddPosInDep.Size = new System.Drawing.Size(233, 26);
            this.btAddPosInDep.TabIndex = 4;
            this.btAddPosInDep.Text = "Додати посаду в обраний відділ";
            this.btAddPosInDep.UseVisualStyleBackColor = true;
            this.btAddPosInDep.Click += new System.EventHandler(this.btAddPosInDep_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 220);
            this.label15.MaximumSize = new System.Drawing.Size(180, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "Поточна кількість співробітників на даній посаді:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Нова посада для відділу:";
            // 
            // btSaveMaxNumberInPos
            // 
            this.btSaveMaxNumberInPos.Location = new System.Drawing.Point(246, 147);
            this.btSaveMaxNumberInPos.Name = "btSaveMaxNumberInPos";
            this.btSaveMaxNumberInPos.Size = new System.Drawing.Size(164, 23);
            this.btSaveMaxNumberInPos.TabIndex = 3;
            this.btSaveMaxNumberInPos.Text = "Зберегти зміни";
            this.btSaveMaxNumberInPos.UseVisualStyleBackColor = true;
            this.btSaveMaxNumberInPos.Click += new System.EventHandler(this.btSaveMaxNumberInPos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.lbDepartList);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 150);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список відділів підприємства";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(625, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Співробітники відділу";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(162, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Штатний розклад";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 478);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік співробітників";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn persIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbDepartList;
        private System.Windows.Forms.ListBox lbPositionList;
        private System.Windows.Forms.ListBox lbEmployeeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCurrentNumEmp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMaxNumberEmp;
        private System.Windows.Forms.ComboBox cbPosNameForDep;
        private System.Windows.Forms.Button btSaveMaxNumberInPos;
        private System.Windows.Forms.Button btAddPosInDep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMaxNumberEmp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

