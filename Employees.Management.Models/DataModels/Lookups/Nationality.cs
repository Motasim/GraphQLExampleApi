using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesManagement.Models.DataModels.Lookups
{
    public class Nationality
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NationalityId { set; get; }

        public string NationalityAName { set; get; }

        public string NationalityEName { set; get; }
    }
}