using System;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;
using MiniShop.Data.Abstract;
using MiniShop.Entity;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductViewModel> GetAll(bool? isHome=null, bool? isActive=null, bool? isDelete=null)
        {
            var products = _productRepository.GetAll();
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            ProductViewModel productViewModel;
            foreach (var p in products)
            {
                if (p.IsHome==isHome)
                {
                    productViewModel = new ProductViewModel
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        ImageUrl = p.ImageUrl,
                        Properties = p.Properties,
                        Url = p.Url
                    };
                    productViewModels.Add(productViewModel);
                }
            }
            return productViewModels;
        }

        public ProductViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

