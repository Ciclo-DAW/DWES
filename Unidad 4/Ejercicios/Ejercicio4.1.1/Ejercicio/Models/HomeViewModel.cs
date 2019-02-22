namespace Ejercicio.Models
{
    // ViewModel para la vista Home, contiene los datos que necesita mostrar,
    // el texto introducido y las rotaciones creadas a partir de dicho texto
    public class HomeViewModel
    {
        public string Text { get; private set; }
        public string[] Rotations { get; private set; }

        public HomeViewModel(string text)
        {
            if(text == null)
            {
                this.Text = "";
            }
            else
            {
                this.Text = text;
            }

            Rotations = new string[this.Text.Length];
            for (int r = 0; r < this.Text.Length; r++)
            {
                Rotations[r] = this.Text.Substring(this.Text.Length - r - 1)
                    + this.Text.Substring(0, this.Text.Length - r - 1);
            }
        }
    }
}
