using System;
using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            var product = new Product(productId)
            {
                CurrentPrice = 10,
                ProductDescription = "T-Shirt",
                ProductName = "T-Shirt"
            };

            Console.WriteLine($"Object: {product}");

            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            var susccess = true;
            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }
            return susccess;
        }
    }
}