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

        public List<Product> GetDeletedProducts(bool? isDeleted)
        {
            var products = AppContext.Products.Where(p => p.IsDelete == isDeleted).ToList();
            return products;
        }

        public List<Product> GetHomePageProducts(bool? isHome)
        {
            var products = AppContext.Products.Where(p => p.IsHome == isHome && p.IsActive && !p.IsDelete).ToList();
            return products;
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}

