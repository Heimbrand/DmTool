using DmTool.Efc.Sql.Dtos;
using DmTool.Efc.Sql.Entities;
using DmTool.Shared.Interfaces;

namespace DmTool.Efc.Sql.IRepositories;

public interface ICharacterRepository : IRepository<Character, int>
{
    Task <IEnumerable<Character>> GetAllByLevelAsync(int level);
    
}