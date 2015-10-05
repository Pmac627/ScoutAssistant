using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ScoutAssistant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            return await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("ScoutIdentity", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<ScoutAssistant.Models.SchoolListModel> SchoolListModels { get; set; }

        public System.Data.Entity.DbSet<ScoutAssistant.Models.SchoolDetailsModel> SchoolDetailsModels { get; set; }

        public System.Data.Entity.DbSet<ScoutAssistant.Models.PlayerModel> PlayerModels { get; set; }
    }
}