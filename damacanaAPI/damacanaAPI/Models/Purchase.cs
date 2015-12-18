using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace damacanaAPI.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public List<Product> PurchaseList { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}