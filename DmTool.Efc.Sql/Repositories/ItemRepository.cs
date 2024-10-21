using DmTool.Efc.Sql.Dtos;
using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;

namespace DmTool.Efc.Sql.Repositories;

public class ItemRepository : IItemRepository
{
    public async Task<IEnumerable<Item>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Item> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public async Task<Item> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }
    public async Task<Item> AddAsync(Item entity)
    {
        throw new NotImplementedException();
    }
    public async Task<Item> UpdateAsync(Item entity)
    {
        throw new NotImplementedException();
    }
    public async Task<Item> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}