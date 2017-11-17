using System;

namespace Mod3_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Ingrese en Nombre del Estudiante:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Estudiante:");
            string lastName = Console.ReadLine();
            // Code to finish getting the rest of the student data
            .....
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} nació el: {2}", first, last, birthday);
        }
    }
}
