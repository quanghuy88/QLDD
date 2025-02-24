using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RIS.Authorization.Roles;
using RIS.Authorization.Users;
using RIS.MultiTenancy;

namespace RIS.EntityFrameworkCore
{
    public class RISDbContext : AbpZeroDbContext<Tenant, Role, User, RISDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RISDbContext(DbContextOptions<RISDbContext> options)
            : base(options)
        {
        }
    }
}
