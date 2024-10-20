using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;

namespace DmTool.Efc.Sql.Repositories;

public class PlayerRepository : IPlayerRepository
{
    public Task<IEnumerable<Player>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Player> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<Player> AddAsync(Player entity)
    {
        throw new NotImplementedException();
    }

    public Task<Player> UpdateAsync(Player entity)
    {
        throw new NotImplementedException();
    }

    public Task<Player> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Player>> GetAllByLevelAsync(int level)
    {
        throw new NotImplementedException();
    }
}