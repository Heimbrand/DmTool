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

    public int? Level { get; set; }
    public double? Experience { get; set; }
    public int UserId { get; set; }
    public List<Item>? Items { get; set; }
}