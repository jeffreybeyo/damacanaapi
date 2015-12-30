using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace damacanaAPI.Models
{
    public class Purchase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        //public virtual ICollection <ProductsPurchases> ProductsPurchasesCollection { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

    }
}