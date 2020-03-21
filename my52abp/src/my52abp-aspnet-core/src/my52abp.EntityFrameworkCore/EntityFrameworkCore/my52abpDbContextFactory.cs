using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using my52abp.Configuration;
using my52abp.Web;

namespace my52abp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class my52abpDbContextFactory : IDesignTimeDbContextFactory<my52abpDbContext>
    {
        public my52abpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<my52abpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            my52abpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(my52abpConsts.ConnectionStringName));

            return new my52abpDbContext(builder.Options);
        }
    }
}
