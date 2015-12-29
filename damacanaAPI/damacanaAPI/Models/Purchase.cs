using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace damacanaAPI.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual ICollection<ProductsPurchases> ProductsPurchases { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}