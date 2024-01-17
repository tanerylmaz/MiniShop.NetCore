using System;
using MiniShop.Core.ViewModels;
using MiniShop.Entity;
namespace MiniShop.Business.Abstract
{
	public interface IProductService
	{
		//CRUD işlemleri için metot imzaları

		List<ProductViewModel> GetAll(bool? isHome, bool? isActive, bool? isDelete);
		ProductViewModel GetById(int id);
		void Create(ProductViewModel model);
		void Update(ProductViewModel model);
		void HardDelete(int id);
		void SoftDelete(int id);
    }
}

