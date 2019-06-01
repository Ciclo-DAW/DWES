using GameStoreApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class JuegoDetailsDto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public float Precio { get; set; }
        public DateTime? FechaSalida { get; set; }

        public Estados Estado { get; set; }

        public GenerosJuego Genero { get; set; }

        public TiendaDto Tienda { get; set; }

    }
}
