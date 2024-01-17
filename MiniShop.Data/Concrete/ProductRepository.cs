using System;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete
{
	public class ProductRepository : GenericRepository<Product>,IProductRepository
	{
		public ProductRepository(AppDbContext appDbContext) :base(appDbContext)
		{

		}


	}
}

