using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAJAX.Models
{
    public class FacturaModel
    {
        public int facturaID { get; set; }
        public int numeroFactura { get; set; }
        public DateTime fechaFactura { get; set; }
        public string nombreVendedor { get; set; }
        public string nombreCliente { get; set; }
        public double subTotal { get; set; }
        public double IGV { get; set; }
        public double total { get; set; }
        public bool estado { get; set; }
    }
}