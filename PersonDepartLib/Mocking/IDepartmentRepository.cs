using System.Collections.Generic;
using PersonDepartLib.Model;

namespace PersonDepartLib.Mocking
{
    public interface IDepartmentRepository
    {
        IEnumerable<Employee> ChekCurrentNumerEmployee_rep(Position pos_, Department dep_);
    }
}