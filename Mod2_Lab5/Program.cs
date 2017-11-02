
using System;

namespace Mod2_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            char cruz = 'X';
            char circulo = 'O';

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(cruz);
                        }
                        else
                        {
                            Console.Write(circulo);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(circulo);
                        }
                        else
                        {
                            Console.Write(cruz);
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
