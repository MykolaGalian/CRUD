using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDepartWF
{
    public partial class MainWF : Form
    {
        public MainWF()
        {
            InitializeComponent();
        }        

        private void MainWF_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit(); // при ручном закрытии формы
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm E1 = new EmployeeForm();
            E1.ShowDialog();  //открывается форма управления сотрудниками - для пользователя 
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm D1 = new DepartmentForm();
            D1.ShowDialog();  //открывается форма управления отделами  
        }

       

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИС - Отдел кадров предприятия. Выполненно - студент ЗПI-71 Галян Н.Н.");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Hide();
            PositionForm Pos1  = new PositionForm();
            Pos1.ShowDialog();  //открывается форма учета должностей
        }
    }
}
