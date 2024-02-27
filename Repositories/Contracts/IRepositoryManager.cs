using System.Runtime.CompilerServices;

namespace Repositories;

public interface IRepositoryManager
{
    IProductRepository Product { get; }
    ICategoryRepository Category { get; }
    IOrderRepository Order { get; }
    void Save();
    Task SaveAsync();
}
