using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productViewModel)
        {
            _productManager.Create(productViewModel);
            return RedirectToAction("Index");
        }
    }
}

