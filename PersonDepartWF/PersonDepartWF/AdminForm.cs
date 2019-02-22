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
using System.Data.Entity;

namespace PersonDepartWF
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        string UserType = "";  // строка для сохранения типа юзера

       // создадим временные обьект 
        Employee emp_ = new Employee();
        int persID = 0;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbEmployees_nonUsers_View(); // вывод данных в listBox
            lbUsers_user_View();
            lbUsers_admin_View();
            TypeOfUser_ViewCB();

            Clear();
            GetNumberPerson();
            GetNumberUser();
            GetNumberAdmin();            
        }

        void Clear() // очистка текстбоксов формы
        {
            tbEmployeeName.Text = tbEmployeeLastName.Text = tbEmployeeLogin.Text = tbEmployeePassword.Text = tbPosition.Text=
                tbDepartment.Text ="";
            TypeOfUser_ViewCB();
        }

        void TypeOfUser_ViewCB() // вывод данных в ComboBox (тип юзера) 
        {
            cbEmployeeTypeOfUser.Text = "Виберіть тип";
        }

        void lbEmployees_nonUsers_View()  // вывод списка всех фамилий (не юзеров) на предприятии в ListBox
        {
            lbEmployees_nonUsers.DataSource = Employee.Employees_nonUsers();   // статический метод из класса Employee 
            lbEmployees_nonUsers.DisplayMember = "LastName";
            lbEmployees_nonUsers.ValueMember = "PersonID";
        }

        void lbUsers_user_View()  // вывод списка всех фамилий (юзеров) на предприятии в ListBox
        {
            lbUsers_user.DataSource = User.Employees_UsersList(); // статический метод из класса User
            lbUsers_user.DisplayMember = "LastName";
            lbUsers_user.ValueMember = "PersonID";
        }

        void lbUsers_admin_View()  // вывод списка всех фамилий (админов) на предприятии в ListBox
        {
            lbUsers_admin.DataSource = User.Employees_AdminsList();  // статический метод из класса User
            lbUsers_admin.DisplayMember = "LastName";
            lbUsers_admin.ValueMember = "PersonID";
        }

        private void cbEmployeeTypeOfUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserType = cbEmployeeTypeOfUser.SelectedItem.ToString();            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             Clear();
        }

        private void btnSave_Click(object sender, EventArgs e) // сохранить изменения для сотрудников
        {
            emp_.Login = tbEmployeeLogin.Text.Trim();  // записываем в поля временного обьекта  
            emp_.Password = tbEmployeePassword.Text.Trim();

            if (cbEmployeeTypeOfUser.Text != "Виберіть тип") // проверка заполнения combBox
            {
                emp_.TypeOfUser = UserType; // выбор из combBox (Admin, User, NULL)
            }
            else { MessageBox.Show("Виберіть тип юзера"); return; }



            emp_.Save_ModificationOfEmp(); //  метод из класса Employee -сохранение изменений для юзера-сотрудника

            Clear();
          
            MessageBox.Show("Зміни внесені");
            GetNumberPerson();
            GetNumberUser();
            GetNumberAdmin();

            lbEmployees_nonUsers_View(); // вывод данных в listBox
            lbUsers_user_View();
            lbUsers_admin_View();
            TypeOfUser_ViewCB();
        }     

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit(); // при ручном закрытии формы
        }

        public void GetNumberPerson() // подсчет количества записей в таб. Persons_ БД
        {
            labelTotalPerson.Text = Person.GetNumberPerson(); // статический метод из класса Person
        }

        public void GetNumberUser() // подсчет количества обычных юзеров в таб. Users  БД
        {
            labelUser.Text = User.GetNumberUser();    // статический метод из класса User 
        }

        public void GetNumberAdmin() // подсчет количества админов в таб. Users  БД
        {
            labelAdmin.Text = User.GetNumberAdmin();      // статический метод из класса User    
        }



        private void lbEmployees_nonUsers_DoubleClick(object sender, EventArgs e) // отображение при двойном клике на ListBox - ах
        {
            persID = Convert.ToInt32(lbEmployees_nonUsers.SelectedValue); // сохраняем ID лица во временном обьекте
            DoubleClicListBox();
        }

        private void lbUsers_user_DoubleClick(object sender, EventArgs e)
        {
            persID = Convert.ToInt32(lbUsers_user.SelectedValue); // сохраняем ID лица во временном обьекте
            DoubleClicListBox();
        }

        private void lbUsers_admin_DoubleClick(object sender, EventArgs e)
        {
            persID = Convert.ToInt32(lbUsers_admin.SelectedValue); // сохраняем ID лица во временном обьекте  
            DoubleClicListBox();
        }

        void DoubleClicListBox()  // отображение выбраного лица в  ListBox
        {
            if (User.Check_RootAdmin(persID))
            {
                MessageBox.Show("Не можна змінювати тип адміністратора з правами root");
                return;
            }

            using (PerDepContext db = new PerDepContext())
            {
                emp_ = Employee.RecEmployee(persID, db); // возврат сущности сотрудника из базы по PersonID
                                                         // статический метод из класса Employee 

                tbEmployeeName.Text = emp_.FirstName;       //  выводим в текстбоксы формы                    
                tbEmployeeLastName.Text = emp_.LastName;
                tbPosition.Text = emp_.Position.PositionName;
                tbDepartment.Text = emp_.Department.DepartName;

                if ((emp_.TypeOfUser == null) || (emp_.TypeOfUser == "NULL")) // проверка 
                {
                    lableTypeOfUser.Text = "None user";
                }
                else { lableTypeOfUser.Text = emp_.TypeOfUser; }

                if ((emp_.Login == null) || (emp_.Login == "NULL")) // проверка 
                {
                    tbEmployeeLogin.Text = "None user";
                }
                else { tbEmployeeLogin.Text = emp_.Login; }

                if ((emp_.Password == null) || (emp_.Password == "NULL")) // проверка 
                {
                    tbEmployeePassword.Text = "None user";
                }
                else { tbEmployeePassword.Text = emp_.Password; }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWF f1 = new MainWF(); //открывается главная форма для обычного пользователя
            f1.ShowDialog();
        }
    }
}
