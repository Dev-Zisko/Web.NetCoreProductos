using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Areas.Productos.Models
{
    public class Productos
    {
        [Key]
        public string pro_codigo { get; set; }

        public string pro_nombre { get; set; }

        public string pro_descripcion { get; set; }

        public decimal pro_precio { get; set; }
    }
}
