
using PersonDepartLib.Mocking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace PersonDepartLib.Model

{
    [Table("Department")]
    public class Department  //департамент на предприятии 
    {
        [Key]
        public int DepartmentID { get; set; }   // идентификатор департамента - ключевое поле
        [Required]
        public string DepartName { get; set; }  // название департамента

        public virtual ICollection<Employee> Employees { get; set; }    // навигационное свойство - список работников департамента
        public virtual ICollection<Position> Position { get; set; } // навигационное свойство - должностной список департамента
        public virtual ICollection<StaffRestrict> StaffRestrict { get; set; } // навигационное свойство -  список ограничений на количество должности для департамента

        public Department(IDepartmentRepository rep , IStaffRestrictRepository staf ) //конструктор по умолчанию (передаем необязательный параметр)
        {
            this.Employees = new List<Employee>();
            this.Position = new List<Position>();
            this.StaffRestrict = new List<StaffRestrict>();

            _departmentRepository = rep ; //Dependency Injection via Constructor (без DI фреймворка )
            _staffRestrictRepository = staf ;
        }

        public Department() 
        {
            this.Employees = new List<Employee>();
            this.Position = new List<Position>();
            this.StaffRestrict = new List<StaffRestrict>();

            _departmentRepository =  new DepartmentRepository(); 
            _staffRestrictRepository =  new StaffRestrictRepository();
        }


        IDepartmentRepository _departmentRepository; // результат рефракторинга для возможности тестирования методов
        IStaffRestrictRepository _staffRestrictRepository;




        public int ChekCurrentNumerEmployee(Position pos_, Department dep_) // проверка текущего количества сотрудников для данной должности в текущем отделе
        {
           
            var Curent = _departmentRepository.ChekCurrentNumerEmployee_rep(pos_, dep_); // вызов через экземпляр изолированного класса доступа к БД 
                                                                                         // который наследует интерфейс IDepartmentRepository
            if (Curent == null) return 0;
            else return Curent.Count();  // текущее кол-во сотрудников на должности 
        }



        public int Chek_ValueMaxNumerEmployee(Position pos_, Department dep_)   // нахождения штатного расписания для данной должности в данном отделе (макс. ограничения)
        {

            StaffRestrict Restr = _staffRestrictRepository.Chek_ValueMaxNumerEmployee_rep(pos_, dep_);// вызов через экземпляр изолированного класса доступа к БД 
                                                                                                      // который наследует  IStaffRestrictRepository
            if (Restr ==null) return 0;
            else return Restr.MaxAmount.Value; // макс. кол-во сотрудников на должности                  
            
        }



        public bool ChekMaxNumerEmployee(Employee emp_) // проверка при добавлении нового сотрудника на достижения максимального 
        {                                                                // количества сотрудников для данной должности и отдела
            using (PerDepContext db = new PerDepContext())
            {
                var Restr = db.StaffRestrict_.Where(x => (x.DepartmentID == emp_.DepartmentID) &&
               (x.PositionID == emp_.PositionID)).FirstOrDefault();             // нахождения штатного расписания для данной 
                                                                                // должности в данном отделе (макс. ограничения)  

                int MaxNumber = Restr.MaxAmount.Value; // макс. кол-во сотрудников на должности 

                var Curent = db.Employees_.Where(x => (x.DepartmentID == emp_.DepartmentID) &&
                (x.PositionID == emp_.PositionID)).ToList();   // нахождение текущего количества работников на данной должности и в данном отделе

                int CurentNumber = Curent.Count();  // текущее кол-во сотрудников на должности

                if (CurentNumber < MaxNumber) return true;
                else return false;
            }
        }      

       

        public static List<Department> Department_List() //список отделов
        {
            using (PerDepContext db = new PerDepContext())
            {
                return db.Departments_.ToList();
            }
        }

        public static Department RecDepartment(int DepId, PerDepContext db) // возврат сущности отдел из базы по DepID
        {                                                                // передаем контекст, т.к. в противно случае ошибка 
                                                                         //ссылки нескольких экземпляров интерфейса IEntityChangeTracker
            return db.Departments_.Where(x => x.DepartmentID == DepId).FirstOrDefault();
        }


        public void Save_ModificationOfDep() // сохранение изменений для отдела
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (this != null)
                {
                    db.Entry(this).State = System.Data.Entity.EntityState.Modified; // вносим изменения в таб. Department БД
                    db.SaveChanges();                                   // исп. EntityState т.к. dep_ получен в одном контексте,
                }                                                        // а изменяется для другого контекста
            }
        }

        public void Add_Dep() // добавление отдела
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (this != null)
                {
                    db.Departments_.Add(this);
                    db.SaveChanges();
                }
            }
        }

        
    }
}