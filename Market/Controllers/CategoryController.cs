using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinesLogic;
using Market.Models;
using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers
{
    public class CategoryController : Controller
    {
        public readonly CategoryRepo _categoryRepo;
        public CategoryController(CategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        
        public IActionResult Index()
        {
            CategoryVM model = new CategoryVM();
            model.categories = _categoryRepo.GetCategories();
            return View(model);
        }

    }
}