﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class Juego
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre del juego")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Range(0, 9999.99)]
        [Display(Name = "Precio")]
        public float Precio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de salida")]
        public DateTime? FechaSalida { get; set; }

        [Display(Name = "Estado del juego")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        [Display(Name = "Género del juego")]
        [EnumDataType(typeof(GenerosJuego))]
        public GenerosJuego Genero { get; set; }

        [Display(Name = "Consola")]
        public Consola Consola { get; set; }
        public int ConsolaId { get; set; }
    }
}