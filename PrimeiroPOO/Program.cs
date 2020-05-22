using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem neymar = new Personagem();
            neymar.time = "PSG";

           Console.WriteLine(neymar.nome);
           Console.WriteLine(neymar.time);
           Console.WriteLine(neymar.Atacar());
          
        }
    }
}
