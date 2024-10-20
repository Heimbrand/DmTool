using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;

namespace DmTool.Efc.Sql.Repositories;

public class ItemRepository : IItemRepository
{
    public Task<IEnumerable<Item>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
    public Task<Item> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Item> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }
    public Task<Item> AddAsync(Item entity)
    {
        throw new NotImplementedException();
    }
    public Task<Item> UpdateAsync(Item entity)
    {
        throw new NotImplementedException();
    }
    public Task<Item> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<Item>> GetAllBySeverityAsync(string severity)
    {
        throw new NotImplementedException();
    }
}