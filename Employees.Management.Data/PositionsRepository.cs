using EmployeesManagement.Data.Persistance;
using EmployeesManagement.Models.DataModels;
using System;
using System.Collections.Generic;

namespace EmployeesManagement.Data.Repositories
{
    public class PositionsRepository
    {
        private readonly EmployeesDataContext employeesDataContext;

        public PositionsRepository(EmployeesDataContext employeesDataContext)
        {
            this.employeesDataContext = employeesDataContext;
        }

        public Position Get(int positionId)
        {
            return new Position();
        }

        public List<Position> Search(Func<Position, bool> searchFunc)
        {
            return new List<Position>();
        }
    }
}