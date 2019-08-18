using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CRM.EntityFrameworkCore
{
    public static class CRMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CRMDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CRMDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}