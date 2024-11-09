using DmTool.Efc.Sql.Entities;

namespace DmTool.Efc.Sql.Dtos;

public class CharacterDto
{ 
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Modified { get; set; }
    public string? Notes { get; set; }
    public string? Portrait { get; set; }

    public string Race { get; set; }
    public int? Level { get; set; }
    public double? Experience { get; set; }
    public int? HitPoints { get; set; }
    public int? HitPointMax { get; set; }
    public string? Size { get; set; }
    public int? Speed { get; set; }
    public int? DarkVision { get; set; }
    public string? Alignment { get; set; }
    public int? ArmorClass { get; set; }
    public string? AlignmentDescription { get; set; }
    public string? CharacterDescription { get; set; }
    public List<string>? Languages { get; set; }
    public int UserId { get; set; }
    public List<Item>? Items { get; set; }
}