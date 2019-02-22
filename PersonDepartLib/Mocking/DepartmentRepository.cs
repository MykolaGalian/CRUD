using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDepartLib.Mocking
{
    public class DepartmentRepository : IDepartmentRepository
    {
        // проверка текущего количества сотрудников для данной должности в текущем отделе
        public IEnumerable<Employee> ChekCurrentNumerEmployee_rep(Position pos_, Department dep_) 
        {
            using (PerDepContext db = new PerDepContext())
            {
                var Curent = db.Employees_.Where(x => (x.DepartmentID == dep_.DepartmentID) &&
                (x.PositionID == pos_.PositionID)).ToList();

                return Curent;                
            }
        }
    }
}
