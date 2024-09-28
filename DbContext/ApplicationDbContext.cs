using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCApp.IdentityEntities;

namespace MVCApp.DbContext
{
    public class ApplicationDbContext : IdentityDbContext< ApplicationUser, ApplicationRole, Guid> //  provide predefined dbset
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
    }
}
