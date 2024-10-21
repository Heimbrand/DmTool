using Microsoft.AspNetCore.Identity;

namespace DmTool.Efc.Sql.Entities;

public class User : IdentityUser
{
    public ICollection<Character>? Characters { get; set; }
}