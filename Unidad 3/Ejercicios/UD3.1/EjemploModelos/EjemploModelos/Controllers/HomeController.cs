using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploModelos.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploModelos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Producto> productos = new List<Producto> {
                new Producto {
                    Nombre = "Teléfono móvil",
                    Precio = 300
                },
                new Producto {
                    Nombre = "Ordenador portátil",
                    Precio = 1000
                },
                new Producto {
                    Nombre = "Tablet",
                    Precio = 600
                }

            };

            Pedido pedido = new Pedido();
            pedido.Productos = productos;
            pedido.Total = productos.Sum(product => product.Precio);

            return View(pedido);
        }
    }
}