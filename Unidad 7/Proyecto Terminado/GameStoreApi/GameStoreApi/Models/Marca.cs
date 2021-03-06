﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.Models
{
    public class Marca
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre de la tienda")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [JsonIgnore]
        public List<Periferico> Perifericos { get; set; }
        //[JsonIgnore]
        public List<Consola> Consolas { get; set; }
    }
}
