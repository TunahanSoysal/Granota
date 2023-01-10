using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Granota.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }

        public Products(int productId, string productName, string productDescription, int productPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
        }

        public Products() { }
    }
}
