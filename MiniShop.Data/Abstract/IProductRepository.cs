using System;
using MiniShop.Entity;

namespace MiniShop.Data.Abstract
{
	public interface IProductRepository :IGenericRepository<Product>
	{
		//temel crud metotları miras aldı producta özgü metot imzaları yazılacak sadece

		List<Product> GetProductsByCategoryId(int categoryId);
		List<Product> GetHomePageProducts(bool? isHome);

	}
}

