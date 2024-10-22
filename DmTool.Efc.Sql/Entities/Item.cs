using System.Runtime.CompilerServices;

namespace DmTool.Efc.Sql.Entities;

public class Item : BaseEntity
{
    public List<string> Content { get; set; }
    public int CharacterId { get; set; }
}