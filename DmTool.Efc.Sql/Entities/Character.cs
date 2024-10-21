namespace DmTool.Efc.Sql.Entities;

public class Character : BaseEntity
{
    public int? Level { get; set; }
    public double? Experience { get; set; }
    public int UserId { get; set; }
    public ICollection<Item>? Items { get; set; }
  
}
