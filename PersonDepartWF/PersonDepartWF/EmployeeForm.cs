using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDepartLib;
using PersonDepartLib.Model;
using PersonDepartLib.Context;
using System.Data.Entity;

namespace PersonDepartWF
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        Employee emp_ = new Employee(); // создадим временные обьекты
        Department dep_ = new Department();
        Position pos_ = new Position();
        StaffRestrict staf_ = new StaffRestrict();

        string StrPosNameForDep = "";  // строка для сохранения названия выбранной должности (для отдела) в combBox
        string MaxNumberEmp = "";  // строка для сохранения  количества сотрудников для выбраной должности в отделе (combBox)
        int CurrentNumberEmp = 0; // сохранение текущего количества сотрудников

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbDepartmentView();
            Clear();          
            PosCB_ViewForDep();  // вывод данных в ComboBox - фамилии
            NumberPos_PosCB_ViewForDep(); // вывод данных в ComboBox - новое число сотрудников на должности
        }


        void lbDepartmentView()  // вывод списка всех отделов предприятия в ListBox
        {
            lbDepartList.DataSource = Department.Department_List(); // стат. метод из класса Department
            lbDepartList.DisplayMember = "DepartName";
            lbDepartList.ValueMember = "DepartmentID";
        }

        private void lbDepartList_DoubleClick(object sender, EventArgs e) // выбор отдела в ListBox по двойному клику
        {
            Clear();
            dep_.DepartmentID = Convert.ToInt32(lbDepartList.SelectedValue); // сохраняем ID отдела 
            lbPositionView();
        }

        void lbPositionView()  // вывод списка всех должностей для выбраного отдела предприятия в ListBox
        {
                lbPositionList.DataSource = StaffRestrict.Position_List(dep_.DepartmentID); // стат. метод из класса  StaffRestrict
                lbPositionList.DisplayMember = "PositionName";
                lbPositionList.ValueMember = "PositionID";            
        }

        private void lbPositionList_DoubleClick(object sender, EventArgs e) // выбор должности в ListBox по двойному клику (для выбраного отдела)
        {
            pos_.PositionID = Convert.ToInt32(lbPositionList.SelectedValue); // сохраняем ID должности вовременном обьекте
            lbEmployeeView();
        }

        void lbEmployeeView()  // вывод списка всех фамилий работников выделенного отдела на предприятии в ListBox
        {
            lbEmployeeList.DataSource = Employee.EmployeeDep_List(dep_.DepartmentID, pos_.PositionID); // стат. метод из класса Employee
            lbEmployeeList.DisplayMember = "LastName";
            lbEmployeeList.ValueMember = "PersonID";
          
            employeeCurentNamber();
        }

        void employeeCurentNamber()  // показываем текущее количество сотрудников на данной должности
        {                               // и макс. количество сотрудников по штатному расписанию

            tbCurrentNumEmp.Text = dep_.ChekCurrentNumerEmployee(pos_, dep_).ToString(); // методы из класса Department
            tbMaxNumberEmp.Text = dep_.Chek_ValueMaxNumerEmployee(pos_, dep_).ToString();

        }
        
        void PosCB_ViewForDep() // вывод данных в ComboBox (новая должность для отдела) - должности
        {      
                cbPosNameForDep.DataSource = Position.Position_List(); // стат. метод из класса  Position
                cbPosNameForDep.DisplayMember = "PositionName";
                cbPosNameForDep.ValueMember = "PositionID";
                cbPosNameForDep.Text = "Виберіть посаду";            
        }

        void NumberPos_PosCB_ViewForDep() // вывод данных в ComboBox (новое количество сотрудников на должности для отдела) 
        {
            cbMaxNumberEmp.Text = "Виберіть кількість";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWF f1 = new MainWF(); //открывается главная форма для обычного пользователя
            f1.ShowDialog();
        }

        void Clear() // очистка текстбоксов формы
        {
            tbName.Text = tbLastName.Text = tbAdress.Text = tbEmail.Text =
            tbSalary.Text = "";
            dtpDateBirth.Value = new DateTime(2000, 1, 1);
            dtpHireDate.Value = new DateTime(2000, 1, 1);

            lbEmployeeList.DataSource = null; // очистка листбоксов (сотрудники и должности) перед выбором нового отдела
            lbPositionList.DataSource = null;

            tbCurrentNumEmp.Text = "";
            tbMaxNumberEmp.Text = "";
        }

        private void lbEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            emp_.PersonID = Convert.ToInt32(lbEmployeeList.SelectedValue); // сохраняем ID сотрудника вовременном обьекте

            using (PerDepContext db = new PerDepContext())
            {
                emp_ = Employee.RecEmployee(emp_.PersonID, db); // стат. метод из класса  Employee - запрашиваем обьект из таб. Employee БД
                tbName.Text = emp_.FirstName;                                        // с выделенным идентификатором и выводим в текстбоксы формы                    
                tbLastName.Text = emp_.LastName;
                tbAdress.Text = emp_.Adress;
                tbEmail.Text = emp_.Email;
                dtpDateBirth.Value = emp_.BirthDate.Value;// Value, для DateTime
                tbSalary.Text = emp_.Salary.ToString();  // для double                  
                dtpHireDate.Value = emp_.HireDate.Value;// Value, для DateTime   
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // добавление нового сотрудника
        {
            if (tbName.Text != "") // проверка заполнения combBox
            {
                emp_.FirstName = tbName.Text.Trim(); // записываем в поля временного обьекта emp_ 
            }
            else { MessageBox.Show("Напишіть ім'я співробітника"); return; }

            if (tbLastName.Text != "") // проверка заполнения combBox
            {
                emp_.LastName = tbLastName.Text.Trim();
            }
            else { MessageBox.Show("Напишіть прізвище співробітника"); return; }

            if (tbAdress.Text != "") // проверка заполнения combBox
            {
                emp_.Adress = tbAdress.Text.Trim();
            }
            else { MessageBox.Show("Напишіть адресу співробітника"); return; }

            if (tbEmail.Text != "") // проверка заполнения combBox
            {
                emp_.Email = tbEmail.Text.Trim();
            }
            else { MessageBox.Show("Напишіть email співробітника"); return; }

            emp_.BirthDate = dtpDateBirth.Value;
            emp_.HireDate = dtpHireDate.Value;

            if (tbSalary.Text != "") // проверка заполнения combBox
            {
                emp_.Salary = Convert.ToDouble(tbSalary.Text);
            }
            else { MessageBox.Show("Напишіть зарплатню для співробітника"); return; }

         
                if ((pos_.PositionID != 0) && (dep_.DepartmentID != 0))
                {
                emp_.PositionID = pos_.PositionID;
                emp_.DepartmentID = dep_.DepartmentID;
                }
                else { MessageBox.Show("Виберіть відділ / посаду співробітника"); return; }

                if (dep_.ChekMaxNumerEmployee(emp_)) // проверка при добавлении нового сотрудника на достижения максимального  
                {                                   // количества сотрудников для данной должности и отдела (метод из класса Departament)
                                   
                    emp_.Add_Employee(); //стат. метод из класса  Employee -  добавление сотрудника
                MessageBox.Show("співробітник доданий");
                }
                else MessageBox.Show("Досягнуто макс. кількість співробітників для даної посади");
            
            Clear();         
            PosCB_ViewForDep();
            NumberPos_PosCB_ViewForDep();
        }


        private void btnSave_Click(object sender, EventArgs e) // сохранение изменений для существующего сотрудника
        {

            if (tbName.Text != "") // проверка заполнения combBox
            {
                emp_.FirstName = tbName.Text.Trim(); // записываем в поля временного обьекта emp_ 
            }
            else { MessageBox.Show("Напишіть ім'я співробітника"); return; }

            if (tbLastName.Text != "") // проверка заполнения combBox
            {
                emp_.LastName = tbLastName.Text.Trim();
            }
            else { MessageBox.Show("Напишіть прізвище співробітника"); return; }

            if (tbAdress.Text != "") // проверка заполнения combBox
            {
                emp_.Adress = tbAdress.Text.Trim();
            }
            else { MessageBox.Show("Напишіть адресу співробітника"); return; }

            if (tbEmail.Text != "") // проверка заполнения combBox
            {
                emp_.Email = tbEmail.Text.Trim();
            }
            else { MessageBox.Show("Напишіть email співробітника"); return; }

            emp_.BirthDate = dtpDateBirth.Value;
            emp_.HireDate = dtpHireDate.Value;

            if (tbSalary.Text != "") // проверка заполнения combBox
            {
                emp_.Salary = Convert.ToDouble(tbSalary.Text);
            }
            else { MessageBox.Show("Напишіть зарплатню для співробітника"); return; }
            
            if ((pos_.PositionID != 0) && (dep_.DepartmentID != 0))
            {
                emp_.PositionID = pos_.PositionID;
                emp_.DepartmentID = dep_.DepartmentID;
            }
            else { MessageBox.Show("Виберіть відділ / посаду співробітника"); return; }

            emp_.Save_ModificationOfEmp();  //стат. метод из класса  Employee -  сохранение изменений для  сотрудника

            Clear();       
            PosCB_ViewForDep();
            NumberPos_PosCB_ViewForDep();

            MessageBox.Show("Зміни внесені");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();            
            PosCB_ViewForDep();
            NumberPos_PosCB_ViewForDep();
        }
        
        private void cbPosNameForDep_SelectedIndexChanged(object sender, EventArgs e) // перевод в строку названия выбранной должности (для отдела)  в combBox
        {
            StrPosNameForDep = cbPosNameForDep.SelectedValue.ToString();
        }

        private void cbMaxNumberEmp_SelectedIndexChanged(object sender, EventArgs e)// перевод в строку количества сотрудников для выбраной должности в отделе (combBox)
        {
            MaxNumberEmp = cbMaxNumberEmp.SelectedIndex.ToString();
        }

        
        private void btnDelete_Click(object sender, EventArgs e) // удаление сотрудника
        {
            if (emp_.FirstName == null)
            {
                MessageBox.Show("Виберіть співробітника для видалення");
                return;
            }

            if (MessageBox.Show("Ви впевнені, що хочете видалити цей запис?", "Видалення співробітника", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                emp_.Delete_Employee(); //стат. метод из класса  Employee - удаление сотрудника

                Clear();         
                PosCB_ViewForDep();
                NumberPos_PosCB_ViewForDep();
                MessageBox.Show("Успішно видалено");
            }
        }

        private void btAddPosInDep_Click(object sender, EventArgs e) // добавление новой должности в отдел 
        {
            if (cbPosNameForDep.Text != "Виберіть посаду") // проверка заполнения combBox
            {
                staf_.PositionID = Convert.ToInt32(StrPosNameForDep); // перевод идентификатора в int  (выбор из combBox)
            }
            else { MessageBox.Show("Виберіть посаду для відділу"); return; }


            if (cbMaxNumberEmp.Text != "Виберіть кількість") // проверка заполнения combBox
            {
                staf_.MaxAmount = Convert.ToInt32(MaxNumberEmp) + 1; // перевод выбраного кол-ва сотрудников в int  (выбор из combBox, +1 - учет индекса)
            }
            else { MessageBox.Show("Виберіть кількість співробітників для нової посади в обраному відділі"); return; }

            staf_.DepartmentID = dep_.DepartmentID;           

            if ((pos_.PositionID != 0) && (dep_.DepartmentID != 0))
            {
                //проверка - отказ если уже существует правило для данных DepID и PosID
                if ( StaffRestrict.Rec_StaffRestrict(dep_.DepartmentID, pos_.PositionID) == null)
                {
                    Position.Position_AddToDep(dep_.DepartmentID, staf_.PositionID); // прикрепление должности к отделу (M_to_M)

                    StaffRestrict.Add_StaffRestrict(staf_);// добавление нового правила (сотрудник - отдел - количество)
                                                           // для штатного расписания

                    MessageBox.Show("Посада додана до штатного розкладу відділу");
                }
                else { MessageBox.Show("Ця посада вже існує в відділі"); return; }

            }
            else { MessageBox.Show("Виберіть посаду / відділ"); return;  }
                   
            Clear();        
            PosCB_ViewForDep();
            NumberPos_PosCB_ViewForDep();

        }

        private void btSaveMaxNumberInPos_Click(object sender, EventArgs e) // сохранение штатного расписания - изменение количества сотрудников на выбраную должность в отделе
        {           

            if ( (pos_.PositionID != 0)  && (dep_.DepartmentID !=0) )
            {
                staf_ = StaffRestrict.Rec_StaffRestrict(dep_.DepartmentID, pos_.PositionID);  // выбор текущей должности - сущности
            }               
            else { MessageBox.Show("Виберіть посаду для якої потрібно змінити штатний розклад"); return; }  

            if (cbMaxNumberEmp.Text != "Виберіть кількість") // проверка заполнения combBox
            {
                staf_.MaxAmount = Convert.ToInt32(MaxNumberEmp) + 1; // перевод выбраного кол-ва сотрудников в int  (выбор из combBox, +1 - учет индекса)
            }
            else { MessageBox.Show("Виберіть кількість співробітників для посади в обраному відділі"); return; }

            CurrentNumberEmp = dep_.ChekCurrentNumerEmployee(pos_, dep_); // текущее количество работников на должности

            StaffRestrict.StaffRestrict_NumberSave(staf_, CurrentNumberEmp);  // вносим изменения в таб. StaffRestric БД если возможно                                                          
           
            Clear();           
            PosCB_ViewForDep();
            NumberPos_PosCB_ViewForDep();
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e) // запрет ввода текста в поля для зарплаты
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
