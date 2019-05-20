using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BussinesLogic
{
    public class ProductRepo
    {
        public List<ProductModel> GetProductsByCategoryId(int id)
        {
            return ReadProducts().Where(x => x.CategoryId == id).ToList();
        }
        private List<ProductModel> ReadProducts()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ProductModel>));
            string path = @"C:\Users\B  A  R  E  V\source\repos\Market\Products.XML";
            List<ProductModel> products = null;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                products = (List<ProductModel>)serializer.Deserialize(fs);
            }

            return products;
        }

        public ProductModel GetProductByProductId(int id)
        {
            return ReadProducts().Find(x => x.ProductId == id);
        }

    }
}
