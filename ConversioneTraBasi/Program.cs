using System;

namespace ConversioneTraBasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(numero, 2));
            Console.ReadLine();

        }
    }
}
