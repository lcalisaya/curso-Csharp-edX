﻿using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an if decision block
            // use this if block to check for an even number


            // Request user input with ReadLine()
            Console.WriteLine("Por favor ingrese un valor entero y presione Enter.");

            // Assign the entered value to the variable input
            // convert input to integer before using
            int input = Int32.Parse( Console.ReadLine());

            // Check to see if the number is even.
            // Here we use the simple task of checking for a remainder when dividing by 2
            // The (%) or modulus operator returns the remainder of integer devision.
            // If the remainder is 0, then the value is able to be divided by 2 with
            // no remainder, which means it is an even number.
            if(input % 2 == 0)
            {
                Console.WriteLine("El número ingresado era un número par.");
            }
            else  // the remainder was not 0 so the value entere is an odd number.
            {
                Console.WriteLine("El número ingresado era un número impar.");
            }
        }
    }
}
