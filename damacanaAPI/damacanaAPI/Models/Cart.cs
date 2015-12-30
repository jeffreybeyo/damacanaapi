using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace damacanaAPI.Models
{
    public class Cart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        //public virtual ICollection<ProductsCarts> ProductsCartsCollection { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}