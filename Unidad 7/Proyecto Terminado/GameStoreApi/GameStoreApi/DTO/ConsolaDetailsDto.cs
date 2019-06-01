using GameStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class ConsolaDetailsDto
    {
        public int ID { get; set; }

        public MarcaDto Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public float Precio { get; set; }
        public DateTime? FechaSalida { get; set; }
        public Estados Estado { get; set; }  
        public TiendaDto Tienda { get; set; }
    }
}
