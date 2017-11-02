using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
             // Create a switch block

            Console.WriteLine("Tamaños de café: 1=pequeño 2=medio 3=grande");
            Console.Write("Por favor ingrese una opción: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "pequeño":
                    cost += 25;
                    break;
                case "2":
                case "medio":
                    cost += 50;
                    break;
                case "3":
                case "grande":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione 1, 2, o 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Por favor inserte {0} pesos.", cost);
            }
            Console.WriteLine("Bar a su servicio.");
        }
    }
}
