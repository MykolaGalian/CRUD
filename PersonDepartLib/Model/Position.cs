
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDepartLib.Model
{
    [Table("Position")]
    public  class Position
    {
        [Key]
        public int PositionID { get; set; }
        [Required]
        public string PositionName { get; set; }
        
        public virtual ICollection<Employee> Employee { get; set; }        
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<StaffRestrict> StaffRestrict { get; set; } // навигационное свойство -  список ограничений на количество должности для департамента

        public Position()
        {
            this.Employee = new List<Employee>();
            this.Department = new List<Department>();
            this.StaffRestrict = new List<StaffRestrict>();
        }

        public static List<Position> Position_List() //список отделов
        {
            using (PerDepContext db = new PerDepContext())
            {
                return db.Position_.ToList();
            }
        }

        public static Position RecPosition(int PosId, PerDepContext db) // возврат сущности отдел из базы по PositionID
        {                                                                // передаем контекст, т.к. в противно случае ошибка 
                                                                         //ссылки нескольких экземпляров интерфейса IEntityChangeTracker
            return db.Position_.Where(x => x.PositionID == PosId).FirstOrDefault();
        }

        public void Add_Position() // добавление должности
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (this != null)
                {
                    db.Position_.Add(this);
                    db.SaveChanges();
                }
            }
        }

        public void Save_ModificationOfPos() // сохранение изменений для должности
        {
            using (PerDepContext db = new PerDepContext())
            {
                if ((this != null))
                {
                    db.Entry(this).State = System.Data.Entity.EntityState.Modified; // вносим изменения в таб. Position БД
                    db.SaveChanges();                                   // исп. EntityState т.к. dep_ получен в одном контексте,
                }                                                        // а изменяется для другого контекста
                
            }
        }

        public static void Position_AddToDep(int DepId, int PosId) // прикрепление должности к отделу (M_to_M)
        {
            using (PerDepContext db = new PerDepContext())
            {
                var recDep = db.Departments_.Where(x => x.DepartmentID == DepId).FirstOrDefault(); // выбор текущего отдела - сущности

                var recPos = db.Position_.Where(x => x.PositionID == PosId).FirstOrDefault(); // выбор текущей должности - сущности
               
                recDep.Position.Add(recPos);  // добавление должностей в отдел через свойство навигации !!!!! (M_to_M)   

                db.SaveChanges();
            }
        }

    }
}
