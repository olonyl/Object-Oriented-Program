using System;

namespace ACM.BusinessLayer
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        public bool Validate()
        {
            return !ProductName.IsEmpty() && CurrentPrice != null;
        }
    }
}
