using EmployeesManagement.Models.DataModelContracts;
using EmployeesManagement.Models.DataModels.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels
{
    public class Employee : IAuditable
    {
        public Employee()
        {
            SubOrdinates = new List<Employee>();
            EmployeePositions = new List<EmployeePosition>();
        }

        [Key]
        public int EmployeeId { set; get; }

        public int EmployeeTypeId { set; get; }

        [ForeignKey("EmployeeTypeId")]
        public EmployeeType EmployeeType { set; get; }

        [StringLength(250)]
        public string EmployeeName { set; get; }


        public DateTime BirthDate { set; get; }

        public int GenderId { set; get; }

        [ForeignKey("GenderId")]
        public Gender Gender { set; get; }

        public byte[] EmployeeImage { set; get; }

        public int? ManagerId { set; get; }

        [ForeignKey("ManagerId")]
        public Employee Manager { set; get; }

        public DateTime EmploymentDate { set; get; }

        public DateTime? ResignDate { set; get; }

        public int NationalityId { set; get; }

        [ForeignKey("NationalityId")]
        public Nationality Nationality { set; get; }

        public DateTime DateTimeCreated { set; get; }

        public DateTime? DateTimeLastUpdated { set; get; }

        public List<Employee> SubOrdinates { set; get; }

        public List<EmployeePosition> EmployeePositions { set; get; }

    }
}
