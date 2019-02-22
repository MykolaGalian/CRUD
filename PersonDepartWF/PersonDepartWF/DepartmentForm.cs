using PersonDepartLib;
using PersonDepartLib.Model;
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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        Department dep_ = new Department(); // создадим временный обьект Department 
        int DepId = 0;

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            lbDepView();
            Clear();
        }

        private void lbDepartments_DoubleClick(object sender, EventArgs e) // по двойному клику в ListBox - возврат сущности отдел из базы по DepID
        {
            DepId = Convert.ToInt32(lbDepartments.SelectedValue);

            using (PerDepContext db = new PerDepContext())
            {
                dep_ = Department.RecDepartment(DepId, db); // статический метод из класса Department
                tbDepName.Text = dep_.DepartName;
            }
        }

        void lbDepView()  // вывод списка всех отделов на предприятии в ListBox
        {
            lbDepartments.DataSource = Department.Department_List(); // статический метод из класса Department
            lbDepartments.DisplayMember = "DepartName";
            lbDepartments.ValueMember = "DepartmentID";
        }


        void Clear() // очистка текстбоксов формы
        {
            tbDepName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWF f1 = new MainWF(); //открывается главная форма для обычного пользователя
            f1.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e) // добавление департамента
        {
            dep_.DepartName = tbDepName.Text.Trim();  // записываем в поля временного обьекта Dep 

            if (tbDepName.Text != "")
            {
                dep_.Add_Dep(); //  метод из класса Department - добавление департамента
                Clear();
                lbDepView();
                MessageBox.Show("Відділ доданий в загальний список");
            }
            else MessageBox.Show("Заповніть поле з назвою відділу");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dep_.DepartName = tbDepName.Text.Trim();  // записываем в поля временного обьекта Dep 

            if (tbDepName.Text != "")
            {
                dep_.Save_ModificationOfDep(); //  метод из класса Department -сохранение изменений для отдела
                Clear();
                lbDepView();
                MessageBox.Show("Зміни внесені");
            }
            else MessageBox.Show("Заповніть поле з назвою відділу");
        }
    }
}
