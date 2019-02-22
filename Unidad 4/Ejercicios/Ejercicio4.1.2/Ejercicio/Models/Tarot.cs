using System;

namespace Ejercicio.Models
{
    // Modelo de negocio, permite calcular el número de Tarot a partir de una fecha
    public class Tarot
    {
        public DateTime Date { get; private set; }
        public int NumeroDeTarot { get; private set; }

        public Tarot(DateTime date)
        {
            if(date != null)
            {
                this.Date = date;
                this.NumeroDeTarot = CalculateTarot();
            }
        }

        private int CalculateTarot()
        {
            int tarot = SumOfDigits(this.Date.Day) + SumOfDigits(this.Date.Month) + SumOfDigits(this.Date.Year);
            while (tarot > 9)
            {
                tarot = SumOfDigits(tarot);
            }
            return tarot;
        }

        private int SumOfDigits(int number)
        {
            int result = number % 10;
            int n = number / 10;
            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }
            return result;
        }
    }
}
