using GameStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class PerifericoDto
    {
        public int ID { get; set; }     
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public TiendaDto Tienda { get; set; }
    }
}
