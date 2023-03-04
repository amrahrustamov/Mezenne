using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mezenne
            int azn = 10000;
            float usd = azn / 1.7f;
            float euro = azn / 1.8036f;
            float rubl = azn / 0.0225f;

            Console.WriteLine("Mebleg (AZN): ");
            Console.WriteLine(azn);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("ABS dollari (USD): ");
            Console.WriteLine(usd);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Avro (EUR): ");
            Console.WriteLine(euro);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Rusya rublu (RUB): ");
            Console.WriteLine(rubl);

            Console.ReadLine();









        }
    }
}