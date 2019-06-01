using GameStoreApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class TiendaDetailsDto
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre de la tienda")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir la direccion de la tienda")]
        [Display(Name = "Direccion URL")]
        public string Direccion { get; set; }


        public List<JuegoDto> Juegos { get; set; }

        public List<PerifericoDto> Perifericos { get; set; }

        public List<ConsolaDto> Consolas { get; set; }
    }
}
