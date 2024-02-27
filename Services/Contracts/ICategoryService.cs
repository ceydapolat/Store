using Entities;

namespace Services;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories(bool trackChanges);
}
