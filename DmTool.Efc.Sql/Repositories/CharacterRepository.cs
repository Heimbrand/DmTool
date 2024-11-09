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
       var characterById = await context.Characters.FindAsync(id);

       if (characterById is null)
              throw new Exception("Character not found.");

       return characterById;
    }
    public async Task<Character> GetByNameAsync(string name)
    {
        var characterByName = await context.Characters.FirstOrDefaultAsync(c => c.Name == name);

        if (characterByName is null)
            throw new Exception("Character not found.");

        return characterByName;
    }
    public async Task AddAsync(Character entity)
    {
        var character = await context.Characters.AddAsync(entity);
        await context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Character entity)
    {
        var character = context.Characters.Update(entity);
        await context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var characterById = await context.Characters.FindAsync(id);

        if (characterById is null)
            throw new Exception("Character not found.");

        context.Characters.Remove(characterById);
        await context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Character>> GetAllByLevelAsync(int level)
    {
        var charactersByLevel = await context.Characters.Where(c => c.Level == level).ToListAsync();

        if (charactersByLevel is null || !charactersByLevel.Any())
            throw new Exception("No characters found.");

        return charactersByLevel;
    }

 
}