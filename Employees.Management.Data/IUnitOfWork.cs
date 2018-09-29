using EmployeesManagement.Data.Repositories;

namespace EmployeesManagement.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        EmployeesRepository Employees { set; get; }

        EmployeeTypesRepository EmployeeTypes { set; get; }

        PositionsRepository Positions { set; get; }

        PositionTypesRepository PositionTypes { set; get; }

    }
}
