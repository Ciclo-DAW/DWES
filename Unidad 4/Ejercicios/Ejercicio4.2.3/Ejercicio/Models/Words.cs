using System.Collections.Generic;

namespace Ejercicio.Models
{
    public class Words
    {
        private static List<string> list = new List<string>();

        // permitimos acceso en modo lectura a la lista de palabras al resto de objetos de la aplicación
        public List<string> List { get => list; }

        // se proporciona un método para que desde el exterior puedan agregarse palabras a la lista
        public void AddWord(string word)
        {
            if (!list.Contains(word)) // comprobamos que la lista NO contiene ya la palabra para evitar duplicados
            {
                list.Add(word); // añadimos la nueva palabra
                list.Sort();  // ordenamos la lista (por defecto al ser cadenas se ordenará por orden alfabético)
            }
        }
    }
}
