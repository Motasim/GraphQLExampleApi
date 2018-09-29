using EmployeesManagement.Data.Persistance;
using EmployeesManagement.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManagement.Data.Repositories
{
    public class EmployeesRepository
    {
        private readonly EmployeesDataContext employeesDataContext;

        public EmployeesRepository(EmployeesDataContext employeesDataContext)
        {
            this.employeesDataContext = employeesDataContext;
        }
        public Employee Get(int employeeId)
        {
            return employeesDataContext.Employees.Find(employeeId);
        }

        public List<Employee> Search(Func<Employee, bool> searchFunc)
        {
            return employeesDataContext.Employees.Where(searchFunc).ToList();
        }
    }
}
