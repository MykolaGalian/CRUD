using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDepartLib.Mocking
{
    public interface IStaffRestrictRepository
    {
        StaffRestrict Chek_ValueMaxNumerEmployee_rep(Position pos_, Department dep_);
    }
}
