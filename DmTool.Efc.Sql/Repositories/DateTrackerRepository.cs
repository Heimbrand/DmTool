using DmTool.Efc.Sql.Entities;
using DmTool.Efc.Sql.IRepositories;
using DmTool.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DmTool.Efc.Sql.Repositories;

public class DateTrackerRepository(DmDbContext context) : IDateTrackerRepository
{
    public async Task<IEnumerable<DateTracker>> GetAllAsync()
    {
        var dateTrackers = await context.DateTrackers.ToListAsync();

        if (dateTrackers is null)
            throw new InvalidOperationException("No DateTrackers found");

        return dateTrackers;
    }

    public async Task<DateTracker> GetByIdAsync(int id)
    {
        var dateTracker = await context.DateTrackers.FindAsync(id);

        if (dateTracker is null)
            throw new NullReferenceException("No DateTracker found with that id");

        return dateTracker;
    }

    public async Task<DateTracker> GetByNameAsync(string name)
    {
        var dateTracker = await context.DateTrackers.FirstOrDefaultAsync(x => x.Name == name);

        if (dateTracker is null)
            throw new NullReferenceException("No DateTracker found with that name");

        return dateTracker;
    }

    public async Task AddAsync(DateTracker entity)
    {
        await context.DateTrackers.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DateTracker entity)
    {
        context.DateTrackers.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var dateTracker = await context.DateTrackers.FindAsync(id);

        if (dateTracker is null)
            throw new NullReferenceException("No DateTracker found with that name");

        context.DateTrackers.Remove(dateTracker);
        await context.SaveChangesAsync();
    }
}