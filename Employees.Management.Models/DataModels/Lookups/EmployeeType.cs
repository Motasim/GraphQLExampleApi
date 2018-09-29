using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels.Lookups
{
    public class EmployeeType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeTypeId { set; get; }

        public string EmployeeTypeEName { set; get; }

        public string EmployeeTypeAName { set; get; }
    }
}
