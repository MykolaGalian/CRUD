
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonDepartLib.Model
{
    [Table("Employee")]   // TPT подход - table per type 
    public class Employee : User               // работник предприятия
    {
        public double? Salary { get; set; }     // з/п      
        public DateTime? HireDate { get; set; } // дата приема на работу

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }  // навигационное свойство - департамент              
        public int? DepartmentID { get; set; }              // внешний ключ (из таб. Departments)

        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }
        public int? PositionID { get; set; }


        public void Save_ModificationOfEmp() // сохранение изменений для сотрудника 
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (this != null)
                {
                    db.Entry(this).State = System.Data.Entity.EntityState.Modified; // вносим изменения в таб. User БД
                    db.SaveChanges();                                   // исп. EntityState т.к. user_ получен в одном контексте,
                }                                                        // а изменяется для другого контекста
            }
        }

        public void Add_Employee() // добавление сотрудника
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (this != null)
                {
                    db.Employees_.Add(this);
                    db.SaveChanges();
                }
            }
        }

        public void Delete_Employee() // удаление сотрудника
        {           
                using (PerDepContext db = new PerDepContext())
                {
                    var entry = db.Entry(this);
                    if (entry.State == System.Data.Entity.EntityState.Detached) db.Employees_.Attach(this); // прикрепим объект к текущему контексту данных
                    db.Users_.Remove(this); // удаляем 
                    db.SaveChanges();                    
                } 
        }     

        public static Employee RecEmployee(int persID, PerDepContext db) // возврат сущности сотрудника из базы по PersonID
        {                                                                // передаем контекст, т.к. в противно случае ошибка 
                                                                         //ссылки нескольких экземпляров интерфейса IEntityChangeTracker
            return db.Employees_.Where(x => x.PersonID == persID).FirstOrDefault();            
        }


        public static List<Employee> Employees_nonUsers() //список сотрудников - не юзеров Employee!!!!
        {
            using (PerDepContext db = new PerDepContext())
            {
                return db.Employees_.Where(x => (x.TypeOfUser == null) || (x.TypeOfUser == "NULL")).ToList();
            }
        }

        public static List<Employee> EmployeeDep_List(int DepId, int PosID)  // вывод списка всех фамилий работников выделенного отдела на предприятии в ListBox
        {
            using (PerDepContext db = new PerDepContext())
            {
                var EmpForPosDepRec = db.Employees_.Where(x => (x.PositionID == PosID) &&
                    (x.DepartmentID == DepId)).ToList(); // выбор строк из таб.Employees_ для данного отдела и должности

               return EmpForPosDepRec;              
            }

        }

        

    }
}