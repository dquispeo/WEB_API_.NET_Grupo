using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAJAX.Models
{
    public class ProductoModel
    {
        public int productoID { get; set; }
        public string codigo { get; set; }
        public double precio { get; set; }
        public int stok { get; set; }
        public bool enabled { get; set; }
    }
}