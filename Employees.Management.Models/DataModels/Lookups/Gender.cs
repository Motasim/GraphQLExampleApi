using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels.Lookups
{
    public class Gender
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GenderId { set; get; }

        [StringLength(100)]
        public string GenderAName { set; get; }

        [StringLength(100)]
        public string GenderEName { set; get; }
    }
}
