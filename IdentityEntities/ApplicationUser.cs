using Microsoft.AspNetCore.Identity;

namespace MVCApp.IdentityEntities
{
    public class ApplicationUser :IdentityUser<Guid>
    {
        public string? PersonName {  get; set; }
    }
}
