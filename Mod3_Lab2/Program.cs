using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Ingrese su primer número: ");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo número: ");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine("El resultado de: {0} dividido {1} es {2}", first, second, result);
        }
        
        // Method Divide() that contains exception handling to deal with 
        // divide by zero exceptions.
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por 0, por favor provea un valor que no sea 0 para su segundo valor");
            }
            return result;
        }
    }
}
