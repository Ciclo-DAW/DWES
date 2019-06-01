using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.Models
{
    public class Tienda
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre de la tienda")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir la direccion de la tienda")]
        [Display(Name = "Direccion URL")]
        public string Direccion { get; set; }


        public List<Juego> Juegos { get; set; }

        public List<Periferico> Perifericos { get; set; }

        public List<Consola> Consolas { get; set; }
    }
}
