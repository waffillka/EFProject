using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace EFProject
{
    class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ApplicationContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(@"d:\\EPAM\\EF\\EFProject\\EFProject\");
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            string connectionString = config.GetConnectionString("MSSQLConnection");
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
