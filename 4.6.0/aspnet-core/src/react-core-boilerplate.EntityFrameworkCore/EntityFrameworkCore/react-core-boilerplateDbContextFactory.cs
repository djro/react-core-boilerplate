using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using react-core-boilerplate.Configuration;
using react-core-boilerplate.Web;

namespace react-core-boilerplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class react-core-boilerplateDbContextFactory : IDesignTimeDbContextFactory<react-core-boilerplateDbContext>
    {
        public react-core-boilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<react-core-boilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            react-core-boilerplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(react-core-boilerplateConsts.ConnectionStringName));

            return new react-core-boilerplateDbContext(builder.Options);
        }
    }
}
