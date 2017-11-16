using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(2, 0);
        }
        
        // Method Divide() accepts two integer arguments and returns the result
        // of dividing first by second
        // We do no validation of the the arguments so a user may pass in a zero
        // in place of the second parameter. This is an illegal operation in Math
        // If we don't validate input or catch the error, the application will crash
        static int Divide(int first, int second)
        {
            int result = first / second;
            return result;
        }
    }
}
