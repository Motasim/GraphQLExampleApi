using System;

namespace EmployeesManagement.Models.DataModelContracts
{
    public interface IAuditable
    {
        DateTime DateTimeCreated { get; set; }
        DateTime? DateTimeLastUpdated { get; set; }
    }
}