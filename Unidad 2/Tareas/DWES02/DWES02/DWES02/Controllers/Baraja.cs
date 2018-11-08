using System;
public class Baraja
{
    public Carta[] Cartas = new Carta[40];

    public string[] Palos = { "bastos", "oros", "copas", "espadas" };

    public Baraja()
    {
        int sum = 0;
        foreach (var item in Palos)
        {
            for (int i = 0; i < 10; i++)
            {
                Cartas[i+sum] = new Carta(item, i + 1);
            }
            sum += 10;
        }
    }

    public void Barajar()
    {
        Random random = new Random();
        for (int t = 0; t < Cartas.Length; t++)
        {
            Carta tmp = Cartas[t];
            int r = random.Next(0, 39);
            Cartas[t] = Cartas[r];
            Cartas[r] = tmp;
        }
    }
}
