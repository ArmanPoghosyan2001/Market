using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinesLogic
{
    public class CategoryRepo
    {
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            categoryModels.Add(new CategoryModel { CategoryName = "Furniture", Id = 1 });
            categoryModels.Add(new CategoryModel { CategoryName = "Sport", Id = 2 });

            return categoryModels;
        }
    }
}
