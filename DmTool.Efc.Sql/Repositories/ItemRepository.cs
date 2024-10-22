using DmTool.Efc.Sql.Dtos;
using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DmTool.Efc.Sql.Repositories;

public class ItemRepository(DmDbContext context) : IItemRepository
{
    public async Task<IEnumerable<Item>> GetAllAsync()
    {
        var allItems = await context.Items.ToListAsync();

        if (allItems is null || !allItems.Any())
            throw new Exception("No items found.");

        return allItems;
    }
    public async Task<Item> GetByIdAsync(int id)
    {
        var itemById = await context.Items.FindAsync(id);

        if (itemById is null)
            throw new Exception("Item not found.");

        return itemById;
    }
    public async Task<Item> GetByNameAsync(string name)
    {
        var  itemByName = await context.Items.FirstOrDefaultAsync(i => i.Name == name);

        if (itemByName is null)
            throw new Exception("Item not found.");

        return itemByName;
    }
    public async Task AddAsync(Item entity)
    {
        var  itemToAdd = await context.Items.AddAsync(entity);
        await context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Item entity)
    {
        var itemToUpdate = context.Items.Update(entity);
        await context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
       var itemToDelete = await context.Items.FindAsync(id);

        if (itemToDelete is null)
            throw new Exception("Item not found.");

        context.Items.Remove(itemToDelete);
        await context.SaveChangesAsync();
    }
}