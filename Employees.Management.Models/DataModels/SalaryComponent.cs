using EmployeesManagement.Models.DataModelContracts;
using EmployeesManagement.Models.DataModels.Lookups;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels
{
    public class SalaryComponent : IAuditable
    {
        [Key]
        public int SalaryComponentId { set; get; }

        //[ForeignKey("EmployeePosition"), Column(Order = 1)]
        public int EmployeeId { set; get; }

        //[ForeignKey("EmployeePosition"), Column(Order = 2)]
        public int PositionId { set; get; }

        [ForeignKey("PositionId,EmployeeId")]
        public EmployeePosition EmployeePosition { set; get; }

        public int SalaryComponentTypeId { set; get; }

        [ForeignKey("SalaryComponentTypeId")]
        public SalaryComponentType SalaryComponentType { set; get; }

        public decimal SalaryComponentValue { set; get; }

        public DateTime DateTimeCreated { set; get; }

        public DateTime? DateTimeLastUpdated { set; get; }
    }
}