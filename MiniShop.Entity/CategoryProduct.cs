using System;
namespace MiniShop.Entity
{
	public class CategoryProduct
	{
		public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public Product Product { get; set; }
	}
}

