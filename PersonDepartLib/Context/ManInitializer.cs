using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDepartLib.Context
{
    public class ManInitializer : IDatabaseInitializer<PerDepContext>
    {
        public void InitializeDatabase(PerDepContext context) // метод для кастомной инициализации БД - Code First
        {

            //if (context.Database.Exists()) context.Database.Delete();
            //context.Database.Create();

           if (context.Database.CreateIfNotExists()) // создать БД если её нет, и записать в БД начальные данные
           { 

            // начальные данные для новых таблиц БД
            using (PerDepContext db = new PerDepContext())
            {
                
                Position enj = new Position()   
                {
                    PositionName = "Інженер"   // PositionID=1
                };
                Position meneg = new Position()
                {
                    PositionName = "Менеджер" // PositionID=2
                };
                db.Position_.AddRange(new List<Position> { enj , meneg }); // добавление должностей


                Department Mech = new Department  //1
                {
                    DepartName = "Механічний цех" // DepartmentID=1
                };
                Mech.Position.Add(enj);
               // Mech.Position.Add(meneg); // добавление должностей в отдел через свойство навигации !!!!! (M_to_M)

                Department Steel = new Department  //2
                {
                    DepartName = "Сталеплавильний цех" // DepartmentID=2
                };
                Steel.Position.Add(enj);
                Steel.Position.Add(meneg); // добавление должностей в отдел через свойство навигации !!!!! (M_to_M)

                db.Departments_.AddRange(new List<Department> { Mech, Steel }); // добавление отделов


                StaffRestrict Mech_enj = new StaffRestrict
                {
                    MaxAmount = 2, // максимум 2 инженера в мех. отделе
                    PositionID = 1,
                    DepartmentID = 1
                };
                //StaffRestrict Mech_meneg = new StaffRestrict
                //{
                //    MaxAmount = 2,   // максимум 2 менеджера в мех. отделе
                //    PositionID = 2,
                //    DepartmentID = 1
                //};
                StaffRestrict Steel_enj = new StaffRestrict
                {
                    MaxAmount = 2, // максимум 2 инженера в Steel. отделе
                    PositionID = 1,
                    DepartmentID = 2
                };
                StaffRestrict Steel_meneg = new StaffRestrict
                {
                    MaxAmount = 2,   // максимум 2 менеджера в Steel. отделе
                    PositionID = 2,
                    DepartmentID = 2
                };

                db.StaffRestrict_.AddRange(new List<StaffRestrict> { Mech_enj,  Steel_meneg , Steel_enj });
                // добавление ограничений на позиции в отделе

                               
                               
                db.Employees_.Add(new Employee
                {

                    FirstName = "Дмитро",
                    LastName = "Петрик",
                    Adress = "Львів",
                    Email = "Petrik@ukr.net",
                    BirthDate = new DateTime(1996, 1, 1),
                    Salary = 10.500,
                    PositionID = 1,
                    HireDate = new DateTime(1999, 10, 25),
                    DepartmentID = 1,
                    Login = "3",
                    Password = "3",
                    TypeOfUser = "User"

                });

                db.Users_.Add(new User   // создаем тип пользователя - админ
                {

                    FirstName = "Root",
                    LastName = "Root",
                    Adress = "Київ",
                    Email = "root@ukr.net",
                    BirthDate = new DateTime(1999, 10, 11),
                    Login = "1",
                    Password = "1",
                    TypeOfUser = "Admin"
                });

                

                db.Employees_.Add(new Employee
                {

                    FirstName = "Кирило",
                    LastName = "Летвів",
                    Adress = "Львів",
                    Email = "Let@ukr.net",
                    BirthDate = new DateTime(1998, 2, 1),
                    Salary = 11.500,
                    PositionID = 2,
                    HireDate = new DateTime(1998, 10, 25),
                    DepartmentID = 2
                });

                
                db.Employees_.Add(new Employee
                {

                    FirstName = "Микола",
                    LastName = "Хвиль",
                    Adress = "Дніпро",
                    Email = "Hvil@ukr.net",
                    BirthDate = new DateTime(1999, 2, 1),
                    Salary = 9.500,
                    PositionID = 1,
                    HireDate = new DateTime(1999, 10, 25),
                    DepartmentID = 2,
                    Login = "4",
                    Password = "4",
                    TypeOfUser = "Admin"
                });

                db.SaveChanges();            

            }
           }
        }
    }
}
