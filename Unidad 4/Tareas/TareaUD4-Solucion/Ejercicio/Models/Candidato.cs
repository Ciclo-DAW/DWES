using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Models
{
    public class Candidato
    {
        [Required(ErrorMessage = "Debe introducir el nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir los apellidos.")]
        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [Phone]
        public string Movil { get; set; }

        public bool Coche { get; set; }

        public string Observaciones { get; set; }

        public string Estudios { get; set; }

        public List<string> Idiomas { get; set; }

        public Candidato()
        {
            Idiomas = new List<string>();
        }
    }
}
