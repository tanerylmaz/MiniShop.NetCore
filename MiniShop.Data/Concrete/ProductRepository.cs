using System;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete
{
	public class ProductRepository : GenericRepository<Product>,IProductRepository
	{
		public ProductRepository(AppDbContext _appDbContext) :base(_appDbContext)
		{

		}

        AppDbContext AppContext {
            get {
                return _dbContext as AppDbContext;
                }
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}

