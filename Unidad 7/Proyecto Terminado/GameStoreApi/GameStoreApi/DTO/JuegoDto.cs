﻿using GameStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.DTO
{
    public class JuegoDto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public TiendaDto Tienda { get; set; }
    }
}
