using System;
public class Baraja
{
    public Carta[] Cartas = new Carta[40];

    public string[] Palos = { "bastos", "oros", "copas", "espadas" };

    public Baraja()
    {

        //for (int i = 0; i < 10; i++)
        //{
        //    Cartas[i] = new Carta(Palos[0], i+1);
        //}
        //for (int i = 10; i < 20; i++)
        //{
        //    Cartas[i] = new Carta(Palos[1], i-9);
        //}
        //for (int i = 20; i < 30; i++)
        //{
        //    Cartas[i] = new Carta(Palos[2], i-19);
        //}
        //for (int i = 30; i < 40; i++)
        //{
        //    Cartas[i] = new Carta(Palos[3], i-29);
        //}

        //Refactorizado
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
