using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x, y;
            x = new Pessoas();
            y = new Pessoas();

            y.Nome = "AILAN";
            y.Idade = 10;

            x.Nome = "PEDRO";
            x.Idade = 11;

            if(x.Idade > y.Idade)
            {
                Console.WriteLine(x.Idade.ToString());
            }
        }
    }
}
