using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels.Lookups
{
    public class SalaryComponentType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalaryComponentTypeId { set; get; }

        [StringLength(200)]
        public string SalaryComponentTypeAName { set; get; }

        [StringLength(200)]
        public string SalaryComponentTypeEName { set; get; }

        public decimal MinSalaryComponentValue { set; get; }
        public decimal MaxSalaryComponentValue { set; get; }
    }
}