using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Models
{
    // ViewModel para la vista Home, contiene los datos que necesita mostrar,
    // las temperaturas en grados centígrados y en grados Fahrenheit
    public class HomeViewModel
    {
        private decimal celsius;
        private decimal fahrenheit;

        // Indica si la última conversión fue de centígrados a Fahrenheit o al revés
        public bool CelsiusToFahrenheit { get; private set; }

        public decimal Celsius
        {
            get
            {
                return celsius;
            }
            set
            {
                celsius = value;
                fahrenheit = celsius * 9 / 5 + 32;
                CelsiusToFahrenheit = true;
            }
        }

        public decimal Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {
                fahrenheit = value;
                celsius = (fahrenheit - 32) * 5 / 9;
                CelsiusToFahrenheit = false;
            }
        }
    }
}
