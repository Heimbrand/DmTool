using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DmTool.Efc.Sql;

public class DmToolContextFactory : IDesignTimeDbContextFactory<DmDbContext>
{
    public DmDbContext CreateDbContext(string[] args)
    {
        // Set the path to the Blazor project's appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DmTool.Blazor"))
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<DmDbContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);

        return new DmDbContext(optionsBuilder.Options);
    }
}