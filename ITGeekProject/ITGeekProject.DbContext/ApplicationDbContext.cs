using ITGeekProject.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ITGeekProject.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()

            : base("ITGeek-DevConnection", throwIfV1Schema: false)
        //: base("ITGeekConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}
