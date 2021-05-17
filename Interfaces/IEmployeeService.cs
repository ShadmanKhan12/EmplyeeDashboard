using EmployeeModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.Interfaces
{
    public interface IEmployeeService
    {
        IList<Employee> GetAll ();
        Employee Create(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
