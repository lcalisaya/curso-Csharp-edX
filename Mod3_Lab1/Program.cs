using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"La suma de 20 y 40 es {result}");
        }

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }       
    }
}