using Entities;

namespace Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(RepositoryContext context) : base(context)
    {
    }
}
