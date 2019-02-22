using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDepartLib.Mocking
{
    public class StaffRestrictRepository : IStaffRestrictRepository
    {
        // нахождения штатного расписания для данной должности в данном отделе (макс. ограничения)
        public StaffRestrict Chek_ValueMaxNumerEmployee_rep(Position pos_, Department dep_)
        {
            using (PerDepContext db = new PerDepContext())
            {
                if (pos_ == null || dep_ == null) return null;

                var Restr = db.StaffRestrict_.Where(x => (x.DepartmentID == dep_.DepartmentID) &&
               (x.PositionID == pos_.PositionID)).FirstOrDefault();             // нахождения штатного расписания для данной 
                                                                                // должности в данном отделе (макс. ограничения)  
                
                return Restr;
            }
        }
    }
}
