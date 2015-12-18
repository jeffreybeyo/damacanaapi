using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace damacanaAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Cartproducts { get; set; }
        public decimal TotalPrice { get; set; }
    }
}