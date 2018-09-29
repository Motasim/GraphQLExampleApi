using EmployeesManagement.Data.Repositories;

namespace EmployeesManagement.Data.UnitOfWork
{
    public class EmployeesUnitOfWork : IUnitOfWork
    {
        public EmployeesRepository Employees { set; get; }
        public EmployeeTypesRepository EmployeeTypes { set; get; }
        public PositionsRepository Positions { set; get; }
        public PositionTypesRepository PositionTypes { set; get; }
    }
}
