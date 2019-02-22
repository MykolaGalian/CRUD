using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDepartLib.Model
{
    [Table("Person")]
    public class Person
    {   [Key]
        public int PersonID { get; set; }  // идентификатор человека - ключевое поле 

        public string FirstName { get; set; }    // свойство - имя человека
        public string LastName { get; set; }     // свойство - фамилия человека
        public string Adress { get; set; }       // свойство - адрес человека
        public string Email { get; set; }        // свойство - эл. адрес
        public DateTime? BirthDate { get; set; }  // свойство - дата рождения


        public static string  GetNumberPerson() // подсчет количества записей в таб. Persons_ БД
        {
            using (PerDepContext db = new PerDepContext())
            {
                var personTotal = db.Persons_.Count();
                return personTotal.ToString();
            }
        }

        
    }
}
