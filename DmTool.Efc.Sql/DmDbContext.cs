using DmTool.Efc.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DmTool.Efc.Sql;

public class DmDbContext(DbContextOptions<DmDbContext> options, IConfiguration configuration)
    : DbContext(options)
{
    private readonly IConfiguration _configuration = configuration;

    public DbSet<Player> Players { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}