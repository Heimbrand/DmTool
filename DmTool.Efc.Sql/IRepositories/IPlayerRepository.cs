using DmTool.Efc.Sql.Entities;
using DmTool.Shared.Interfaces;

namespace DmTool.Efc.Sql.IRepositories;

public interface IPlayerRepository : IRepository<Player, int>
{
    Task <IEnumerable<Player>> GetAllByLevelAsync(int level);
}