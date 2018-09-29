using EmployeesManagement.Models.DataModelContracts;
using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models.DataModels
{
    public class Position : IAuditable
    {
        public Position()
        {
            EmployeePositions = new List<EmployeePosition>();
        }

        public int PositionId { set; get; }

        public string PositionEName { set; get; }

        public string PositionAName { set; get; }

        public decimal? MinSalary { set; get; }

        public decimal? MaxSalary { set; get; }

        public DateTime DateTimeCreated { set; get; }

        public DateTime? DateTimeLastUpdated { set; get; }

        public List<EmployeePosition> EmployeePositions { set; get; }
    }
}