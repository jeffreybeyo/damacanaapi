using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace damacanaAPI.Models
{
    public class CartDTO
    {
        public int Id { get; set; }
        public List<int> ProductID { get; set; }
    }
}