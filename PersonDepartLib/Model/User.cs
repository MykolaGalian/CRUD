
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace PersonDepartLib.Model
{
    [Table("User")] // TPT подход - table per type 
    public class User : Person  // пользователь приложения
    {
        public string Login { get; set; }       // логин пользователя  (может быть NULL - если не юзер приложения)
        public string Password { get; set; }     // пароль пользователя   (может быть NULL)
        public string TypeOfUser { get; set; }  // тип пользователя  - админ/обычный юзер (может быть NULL)




        public static string GetNumberUser() // подсчет количества обычных юзеров в таб. Users  БД
        {
            using (PerDepContext db = new PerDepContext())
            {
                var UserTotal = db.Users_.Where(x => x.TypeOfUser == "User").Count();
                return UserTotal.ToString();
            }
        }

        public static string GetNumberAdmin() // подсчет количества админов в таб. Users  БД
        {
            using (PerDepContext db = new PerDepContext())
            {
                var AdminTotal = db.Users_.Where(x => x.TypeOfUser == "Admin").Count();
                return AdminTotal.ToString();
            }
        }        


        public static List<User> Employees_UsersList() //список сотрудников - юзеров
        {
            using (PerDepContext db = new PerDepContext())
            {
                return db.Users_.Where(x => x.TypeOfUser == "User").ToList();
            }
        }

        public static List<User> Employees_AdminsList() //список сотрудников - админов
        {
            using (PerDepContext db = new PerDepContext())
            {
                return db.Users_.Where(x => x.TypeOfUser == "Admin").ToList();
            }
        }      

        public static bool Check_RootAdmin(int persID)  // проверка админа с правами root (тип User)
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (db.Employees_.Where(x => x.PersonID == persID).FirstOrDefault() == null)
                    return true;
                else return false;
            }
        }

        public static User Log_In_UserAdmin(string Login, string password, PerDepContext db) // возврат сущности по Login / Password
        {                                                                // передаем контекст, т.к. в противно случае ошибка 
                                                                         //ссылки нескольких экземпляров интерфейса IEntityChangeTracker
            return db.Users_.Where(x => (x.Login == Login) && (x.Password == password)).FirstOrDefault();
        } 

    }
}