using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Factura
    {
        [Key]
        public int facturaID { get; set; }
        [Required]
        public int numeroFactura { get; set; }
        [Required]
        public DateTime fechaFactura { get; set; }
        [Required]
        public string nombreVendedor { get; set; }
        [Required]
        public string nombreCliente { get; set; }
        public double subTotal { get; set; }
        public double IGV { get; set; }
        public double total { get; set; }
        public bool estado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
