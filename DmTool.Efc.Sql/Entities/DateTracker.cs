namespace DmTool.Efc.Sql.Entities;

public class DateTracker : BaseEntity
{
    public int? Day { get; set; }
    public int? Month { get; set; }
    public string? Year { get; set; } // ex: 1500 DR

}