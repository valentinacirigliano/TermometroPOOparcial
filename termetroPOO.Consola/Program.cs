using System;
using termometroPOOparcial.Entidades;

namespace termetroPOO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Fahrenheit(120);
            var f2 = new Fahrenheit(130);
            var c1 = new Celsius(20);
            var c2 = new Celsius(20);
            var c3=new Celsius(100);
            var k1 = new Kelvin(100);
            var k2 = new Kelvin(50);
            Console.WriteLine((f1 + f2).ToString());
            Console.WriteLine((c1 + f1).ToString());
            Console.WriteLine((f1 + c1).ToString());
            Console.WriteLine((c1+c2).ToString());
            Console.WriteLine((k1+k2).ToString());
            Console.WriteLine((c1+k1).ToString());
            Console.WriteLine((k1 + f2).ToString());
            if (c1 == c2)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            if (c3 == k1)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

        }
    }
}
