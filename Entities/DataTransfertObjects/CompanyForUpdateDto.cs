using System.Collections.Generic;

namespace Entities.DataTransfertObjects
{
    public class CompanyForUpdateDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}