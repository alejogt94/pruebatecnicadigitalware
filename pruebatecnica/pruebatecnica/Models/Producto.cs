using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebatecnica.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Disponibilidad { get; set; }

    }
}
