using Microsoft.AspNetCore.Identity;

namespace CineProyecto.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
