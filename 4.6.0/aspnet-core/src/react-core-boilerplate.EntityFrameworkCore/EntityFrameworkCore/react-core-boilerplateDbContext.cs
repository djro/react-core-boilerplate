using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using react-core-boilerplate.Authorization.Roles;
using react-core-boilerplate.Authorization.Users;
using react-core-boilerplate.MultiTenancy;

namespace react-core-boilerplate.EntityFrameworkCore
{
    public class react-core-boilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, react-core-boilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public react-core-boilerplateDbContext(DbContextOptions<react-core-boilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
