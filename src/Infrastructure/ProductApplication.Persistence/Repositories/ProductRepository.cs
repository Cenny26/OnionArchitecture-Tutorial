using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Domain.Entities;
using ProductApplication.Persistence.Context;

namespace ProductApplication.Persistence.Repositories
{
    public class ProductRepository : GenericRepositoryAsync<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
