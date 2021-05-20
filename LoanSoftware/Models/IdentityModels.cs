using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using LoanSoftware.Models.LoanModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace LoanSoftware.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string BranchCode { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }


    public class ApplicationRoleManager : RoleManager<IdentityRole>
    {
        public ApplicationRoleManager(IRoleStore<IdentityRole, string> store) : base(store)
        {
        }
        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context.Get<ApplicationDbContext>());
            return new ApplicationRoleManager(roleStore);
        }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<MemberLoanInfo> MemberLoanInfo { get; set; }
        public DbSet<CurrentSaving> CurrentSavings { get; set; }
        public DbSet<BiMudaraba> BiMudaraba { get; set; }
        public DbSet<OtherBank> OtherBank { get; set; }
        public DbSet<RetentionProperty> RetentionProperty { get; set; }
        public DbSet<Guarantor> Guarantor { get; set; }
        public DbSet<TRInvestment> TRInvestment { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Area> Areas { get; set; }

        public DbSet<BranchLimit> BranchLimits { get; set; }
        public DbSet<FormStatus> FormStatus { get; set; }
    }
}