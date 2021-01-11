using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Domain
{
    public class Producto
    {
        [Key]
        public int productoID { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public double precio { get; set; }
        [Required]
        public int stok { get; set; }
        public bool enabled { get; set; }
        public virtual ICollection<Factura> Facturas{ get; set; }
    }
}
