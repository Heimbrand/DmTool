namespace DmTool.Shared.Interfaces;

public interface IRepository<IEntity, Tid> where IEntity : IEntity<Tid> 
{
    Task <IEnumerable<IEntity>>GetAllAsync();
    Task <IEntity> GetByIdAsync(Tid id);
    Task<IEntity> GetByNameAsync(string name);
    Task <IEntity> AddAsync(IEntity entity);
    Task <IEntity> UpdateAsync(IEntity entity);
    Task <IEntity> DeleteAsync(Tid id);
}