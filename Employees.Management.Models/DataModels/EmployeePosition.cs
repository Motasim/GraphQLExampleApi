using EmployeesManagement.Models.DataModelContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels
{
    [Table("EmployeesPositions")]
    public class EmployeePosition : IAuditable
    {
        public EmployeePosition()
        {
            SalaryComponents = new List<SalaryComponent>();
        }


        [Key, Column(Order = 1)]
        public int EmployeeId { set; get; }

        [Key, Column(Order = 2)]
        public int PositionId { set; get; }


        [ForeignKey("EmployeeId")]
        public Employee Employee { set; get; }

        [ForeignKey("PositionId")]
        public Position Position { set; get; }

        public List<SalaryComponent> SalaryComponents { set; get; }

        public DateTime DateTimeCreated { set; get; }

        public DateTime? DateTimeLastUpdated { set; get; }
    }
}
