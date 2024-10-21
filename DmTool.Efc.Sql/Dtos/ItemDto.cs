namespace DmTool.Efc.Sql.Dtos;

public class ItemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Modified { get; set; }
    public string? Notes { get; set; }
    public string? Portrait { get; set; }

    public List<string>? ItemOutcomes { get; set; }
    public int CharacterId { get; set; }
}