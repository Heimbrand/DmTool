using DmTool.Efc.Sql.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DmTool.Efc.Sql;

public class DmDbContext : IdentityDbContext<User>
{
    public DmDbContext(DbContextOptions<DmDbContext> options) : base(options)
    {
    }

    public DbSet<Character> Characters { get; set; }
    public DbSet<Item> Items { get; set; }
    public override DbSet<User> Users { get; set; }
}