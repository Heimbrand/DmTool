﻿namespace DmTool.Shared.Interfaces;

public interface IRepository<IEntity, Tid> where IEntity : IEntity<Tid> 
{
    Task <IEnumerable<IEntity>>GetAllAsync();
    Task <IEntity> GetByIdAsync(Tid id);
    Task<IEntity> GetByNameAsync(string name);
    Task AddAsync(IEntity entity);
    Task UpdateAsync(IEntity entity);
    Task DeleteAsync(Tid id);
}