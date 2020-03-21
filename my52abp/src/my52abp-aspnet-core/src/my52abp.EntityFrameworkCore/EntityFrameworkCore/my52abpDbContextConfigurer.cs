using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace my52abp.EntityFrameworkCore
{
    public static class my52abpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<my52abpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<my52abpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
