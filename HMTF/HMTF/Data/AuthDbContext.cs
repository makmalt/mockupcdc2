using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace HMTF.Data


    // pake identify
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // seed roles (user, admin, superadmin)
            var adminRoleId = "5e44c870-cda1-4197-91f6-83306d9ee15c"; // guid generate
            var superAdminRoleId = "d8445325-1883-48d0-9368-bede90695018"; // guid generate
            var userRoleId = "a2bb0824-032e-4b92-9adc-23f7bb6de2b5"; // guid generate

            var rules = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                }, 
                new IdentityRole
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin",
                    Id = superAdminRoleId,
                    ConcurrencyStamp = superAdminRoleId
                }, 
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "User",
                    Id = userRoleId,
                    ConcurrencyStamp = userRoleId
                },
            };

            builder.Entity<IdentityRole>().HasData(rules);

            // seed superAdminUser
            var superAdminId = "6dadb68d-b036-412d-8743-185c4bd188a9";
            var superAdminUser = new IdentityUser
            {
                UserName = "SuperAdmin@admin.com",
                Email = "SuperAdmin@admin.com",
                NormalizedEmail = "SuperAdmin@admin.com".ToUpper(),
                NormalizedUserName = "superAdmin@admin.com".ToUpper(),
                Id = superAdminId,
            };

            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                .HashPassword(superAdminUser, "superAdmin123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            // add all roles to superAdminUser
            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = superAdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = superAdminId
                },
            };

            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);    

        }
    }
}
