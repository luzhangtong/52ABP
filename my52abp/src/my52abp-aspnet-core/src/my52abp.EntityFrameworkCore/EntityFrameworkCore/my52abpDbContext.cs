using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using my52abp.Authorization.Roles;
using my52abp.Authorization.Users;
using my52abp.MultiTenancy;

namespace my52abp.EntityFrameworkCore
{
    public class my52abpDbContext : AbpZeroDbContext<Tenant, Role, User, my52abpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public my52abpDbContext(DbContextOptions<my52abpDbContext> options)
            : base(options)
        {
        }
    }
}
