using System;
using System.Diagnostics;

namespace ACM.BusinessLayer
{
    [DebuggerDisplay("Id= {ProductId}, Description={ProductDescription,nq}")]
    public class Product : EntityBase
    {
        private string _productName;

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
        public string ProductName
        {
            get => _productName.InsertSpaces();
            set => _productName = value;
        }

        public override bool Validate()
        {
            return !ProductName.IsEmpty() && CurrentPrice != null;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
