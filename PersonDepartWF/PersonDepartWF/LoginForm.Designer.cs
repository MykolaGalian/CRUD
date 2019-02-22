namespace PersonDepartWF
{
    partial class LoginForm
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClear_inter = new System.Windows.Forms.Button();
            this.btInter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(117, 99);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(177, 20);
            this.tbPass.TabIndex = 11;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(118, 53);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(177, 20);
            this.tbUserName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логін";
            // 
            // btClear_inter
            // 
            this.btClear_inter.BackColor = System.Drawing.Color.GhostWhite;
            this.btClear_inter.Location = new System.Drawing.Point(324, 98);
            this.btClear_inter.Name = "btClear_inter";
            this.btClear_inter.Size = new System.Drawing.Size(94, 23);
            this.btClear_inter.TabIndex = 7;
            this.btClear_inter.Text = "ОЧИСТИТИ";
            this.btClear_inter.UseVisualStyleBackColor = false;
            this.btClear_inter.Click += new System.EventHandler(this.btClear_inter_Click);
            // 
            // btInter
            // 
            this.btInter.BackColor = System.Drawing.Color.GhostWhite;
            this.btInter.Location = new System.Drawing.Point(324, 52);
            this.btInter.Name = "btInter";
            this.btInter.Size = new System.Drawing.Size(94, 23);
            this.btInter.TabIndex = 6;
            this.btInter.Text = "ВХІД";
            this.btInter.UseVisualStyleBackColor = false;
            this.btInter.Click += new System.EventHandler(this.btInter_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 177);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear_inter);
            this.Controls.Add(this.btInter);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація - ІС Відділ кадрів підприємства";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClear_inter;
        private System.Windows.Forms.Button btInter;
    }
}