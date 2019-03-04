using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace react-core-boilerplate.EntityFrameworkCore
{
    public static class react-core-boilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<react-core-boilerplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<react-core-boilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
