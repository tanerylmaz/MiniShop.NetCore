﻿using System;
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
            List<Product> products;
            if (isHome==null)
            {
                products = _productRepository.GetAll();
            }
           
            else
            {
                products = _productRepository.GetHomePageProducts(isHome);

            }
            //List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            //ProductViewModel productViewModel;
            //foreach (var p in products)
            //{
            //        productViewModel = new ProductViewModel
            //        {
            //            Id = p.Id,
            //            Name = p.Name,
            //            Price = p.Price,
            //            ImageUrl = p.ImageUrl,
            //            Properties = p.Properties,
            //            Url = p.Url
            //        };
            //        productViewModels.Add(productViewModel);
            //}

            List<ProductViewModel> productViewModels = products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                ImageUrl=p.ImageUrl,
                Price=p.Price,
                Properties=p.Properties,
                Url=p.Url

            }).ToList(); ;
            return productViewModels;
        }

        public ProductViewModel GetById(int id)
        {
            Product product = _productRepository.GetById(id);
            ProductViewModel productViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Properties = product.Properties,
                Url = product.Url
            };
            return productViewModel;
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

