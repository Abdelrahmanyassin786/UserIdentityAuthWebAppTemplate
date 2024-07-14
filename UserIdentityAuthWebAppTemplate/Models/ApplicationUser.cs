using Microsoft.AspNetCore.Identity;

namespace UserIdentityAuthWebAppTemplate.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
