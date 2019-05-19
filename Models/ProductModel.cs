using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ProductInfo { get; set; }
        //public string ProductImagePath { get; set; }
    }
}
