using System;
using System.Globalization;

namespace Study_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definição do tipo
            Triangulo x, y;
            //objetos
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com a medidas de X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Area = x.Area();

            Console.WriteLine(Area.ToString());

        }
    }
}
