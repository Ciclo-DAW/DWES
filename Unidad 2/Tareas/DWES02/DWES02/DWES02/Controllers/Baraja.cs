using System;
public class Baraja
{
    public Carta[] cartas = new Carta[40];

    public string[] palos = { "bastos", "oros", "copas", "espadas" };

    public Baraja()
    {
        int sum = 0;
        foreach (var item in palos)
        {
            for (int i = 0; i < 10; i++)
            {
                cartas[i+sum] = new Carta(item, i + 1);
            }
            sum += 10;
        }
    }

    public void Barajar()
    {
        Random random = new Random();
        for (int t = 0; t < cartas.Length; t++)
        {
            Carta tmp = cartas[t];
            int r = random.Next(0, 39);
            cartas[t] = cartas[r];
            cartas[r] = tmp;
        }
    }
}
