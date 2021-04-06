using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransfertObjects
{
    public class CompanyForCreationDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}