using System.ComponentModel.DataAnnotations;
using DmTool.Shared.Interfaces;

namespace DmTool.Efc.Sql.Entities;

public class BaseEntity : IEntity<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Notes { get; set; }
    public string? Img { get; set; }
}