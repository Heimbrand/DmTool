namespace DmTool.Shared.Interfaces;

public interface IEntity<T>
{
    T Id { get; set; }
}