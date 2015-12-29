using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace damacanaAPI.Models
{
    class ProductsCarts
    {
        public int Id { get; set; }

        public int Price { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }

        public int CartId { get; set; }
    }
}
