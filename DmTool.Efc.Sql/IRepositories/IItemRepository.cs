using DmTool.Efc.Sql.Entities;
using DmTool.Shared.Interfaces;

namespace DmTool.Efc.Sql.IRepositories;

public interface IItemRepository : IRepository<Item, int>
{
    Task <IEnumerable<Item>> GetAllBySeverityAsync(string severity);
}