using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinesLogic;
using Market.Models;
using Market.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers
{
    public class ProductController : Controller
    {
        public readonly ProductRepo _productRepo = new ProductRepo();
        public ProductController(ProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public IActionResult GetProductsByCategoryId(int id)
        {
            ProductsVM model = new ProductsVM();
            model.products = _productRepo.GetProductsByCategoryId(id);
            return View(model);
        }

        public IActionResult GetProductByProductId(int id)
        {
            ProductVM model = new ProductVM();
            model.product = _productRepo.GetProductByProductId(id);
            return View(model);
        }
    }
}