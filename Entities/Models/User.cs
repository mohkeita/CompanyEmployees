using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

    }
}