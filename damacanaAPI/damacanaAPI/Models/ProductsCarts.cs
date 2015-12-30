using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace damacanaAPI.Models
{
    class ProductsCarts
    {
        public int Id { get; set; }

        [Required]
        public int Price { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public int CartId { get; set; }
    }
}
