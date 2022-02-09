using System.Collections.Generic;

namespace ACM.BusinessLayer
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            return new Product(productId)
            {
                CurrentPrice = 10,
                ProductDescription = "T-Shirt",
                ProductName = "T-Shirt"
            };
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}