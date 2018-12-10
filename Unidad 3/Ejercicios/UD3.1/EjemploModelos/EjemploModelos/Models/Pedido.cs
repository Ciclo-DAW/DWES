using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploModelos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Total { get; set; }
    }
}
