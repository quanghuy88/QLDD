using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RIS.EntityFrameworkCore
{
    public static class RISDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RISDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RISDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
