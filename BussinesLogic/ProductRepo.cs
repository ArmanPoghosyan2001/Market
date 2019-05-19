using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesLogic
{
    public class ProductRepo
    {
        public List<ProductModel> GetProductsByCategoryId(int id)
        {
            return CreateProducts().Where(x => x.CategoryId == id).ToList();
        }
        private List<ProductModel> CreateProducts()
        {
            List<ProductModel> productModels = new List<ProductModel>();
            productModels.Add(new ProductModel { CategoryId = 1, ProductId = 1, ProductName = "Sofa", Price = 150000, ProductInfo = "Sofa's Description" });
            productModels.Add(new ProductModel { CategoryId = 1, ProductId = 2, ProductName = "Chairs", Price = 13000, ProductInfo = "Chairs' Description" });
            productModels.Add(new ProductModel { CategoryId = 2, ProductId = 3, ProductName = "Spindle", Price = 1000, ProductInfo = "Spindle's Description" });
            return productModels;
        }

        public ProductModel GetProductByProductId(int id)
        {
            return CreateProducts().Find(x => x.ProductId == id);
        }

    }
}
