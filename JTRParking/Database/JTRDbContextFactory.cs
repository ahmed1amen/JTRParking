using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace JTRParking.Database
{
    public class JTRDbContextFactory : IDesignTimeDbContextFactory<JTRDbContext>
    {
        public JTRDbContext CreateDbContext(string[] args)
        {
            // Build config manually, avoiding Application.StartupPath
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // EF tools run here, so base path points to the project folder
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<JTRDbContext>();
            string connectionString = configuration.GetConnectionString("JTRParkingConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new JTRDbContext(optionsBuilder.Options);
        }
    }
}
