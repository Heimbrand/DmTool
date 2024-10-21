using DmTool.Efc.Sql.Dtos;
using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DmTool.Efc.Sql.Repositories;

public class CharacterRepository(DmDbContext context) : ICharacterRepository
{
    public async Task<IEnumerable<Character>> GetAllAsync()
    {
       var allCharacters = await context.Characters.ToListAsync();

       if (allCharacters is null || !allCharacters.Any())
           throw new Exception("No characters found.");

       return allCharacters;
    }

    public async Task<Character> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Character> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Character> AddAsync(Character entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Character> UpdateAsync(Character entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Character> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Character>> GetAllByLevelAsync(int level)
    {
        throw new NotImplementedException();
    }
}