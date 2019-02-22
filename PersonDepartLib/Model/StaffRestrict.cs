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
    [Table("StaffRestrict")]
    public class StaffRestrict
    {
        [Key]
        public int StaffRestrictID { get; set; }
        public int? MaxAmount { get; set; }     // макс. количество данной дожности в данном отделе

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
        public int DepartmentID { get; set; }

        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }
        public int PositionID { get; set; }


        public static List<Position> Position_List(int DepID)  // вывод списка всех должностей для выбраного отдела предприятия в ListBox
        {
            using (PerDepContext db = new PerDepContext())
            {
                var PositionForDepRec = db.StaffRestrict_.Where(x => x.DepartmentID == DepID).ToList(); // выбор строк из таб.StaffRestrict_ для данного отдела 

                var PosForDep = from v in PositionForDepRec                                // сопоставление PositionID и PositionName из таб. StaffRestrict_ и Position_
                                join e in db.Position_ on v.PositionID equals e.PositionID
                                select new Position
                                {
                                    PositionID = v.PositionID,
                                    PositionName = e.PositionName
                                };
               return PosForDep.ToList();                
            }
        }

        public static void Add_StaffRestrict(StaffRestrict staf_) // добавление нового правила (сотрудник - отдел - количество)
        {                                                          // для штатного расписания
            using (PerDepContext db = new PerDepContext())
            {
                db.StaffRestrict_.Add(staf_);
                db.SaveChanges();
            }
        }

        // возврат правила (штатного расписания) для отдела и должности 
        public static StaffRestrict Rec_StaffRestrict(int DepID, int PosID) 
        {                                                         
            using (PerDepContext db = new PerDepContext())
            {
                return db.StaffRestrict_.Where(x => (x.DepartmentID == DepID) && (x.PositionID == PosID)).FirstOrDefault();
            }
        }

        // сохранение макс. количества сотрудников для выбранного штатного расписания
        public static void StaffRestrict_NumberSave(StaffRestrict staf, int CurrentNumberEmp)
        {
            using (PerDepContext db = new PerDepContext())
            {
                // проверка новое макс. количество сотрудников на должности должно быть >= чем
                // текущее количество сотрудников на этой должности
                if (staf.MaxAmount >= CurrentNumberEmp)
                {
                    db.Entry(staf).State = System.Data.Entity.EntityState.Modified; // вносим изменения в таб. StaffRestric БД
                    db.SaveChanges();
                    MessageBox.Show("Зміни до штатного розпису внесені");
                }
                else MessageBox.Show("Зараз не можна зменшити кількість працівників за штатним розкладом." +
                    "Спочатку перевід співробітників в ін. відділи або звільніть з цієї посади.");
            }
        }

    }



}
