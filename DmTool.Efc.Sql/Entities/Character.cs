namespace DmTool.Efc.Sql.Entities;

public class Character : BaseEntity
{
    public string Race { get; set; }
    public int? Level { get; set; }
    public double? Experience { get; set; }
    public string? Alignment { get; set; }
    public int? ArmorClass { get; set; }
    public string? AlignmentDescription { get; set; }
    public string? CharacterDescription { get; set; } 
    public int UserId { get; set; }
    public ICollection<Item>? Items { get; set; }
  
}
