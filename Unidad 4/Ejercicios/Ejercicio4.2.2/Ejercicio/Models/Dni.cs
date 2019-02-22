using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Models
{
    public class Dni
    {
        // almacenamos una cadena que contiene todas las letras, estando cada una en la posición 
        // equivalente al número que corresponde según la tabla
        private static readonly string Letters = "TRWAGMYFPDXBNJZSQVHLCKE";

        private string dniSinLetra;
        private string dni;

        [Required(ErrorMessage = "Debe introducir su DNI sin la letra final")]
        [RegularExpression(pattern: "[0-9]{8}",
            ErrorMessage = "El DNI debe contener 8 dígitos sin letra final")]
        public string DniSinLetra
        {
            get
            {
                return dniSinLetra;
            }
            set
            {
                dniSinLetra = value;
                dni = value + Letter(value);
            }
        }

        public string DniCompleto
        {
            get
            {
                return dni;
            }
        }

        private char Letter(string dni)
        {
            // el método Parse está disponible en todos los tipos numéricos y convierte una cadena de texto a un número
            try
            {
                long number = long.Parse(dni);

                int pos = (int)number % 23; // calculamos el resto de dividir por 23

                // devolvemos la letra correspondiente para el número resultante
                return Letters[pos];
            }
            catch (Exception e) // evita que la aplicación rompa si el dni introducido no es numérico
            {
                return ' ';
            }
        }

    }
}
