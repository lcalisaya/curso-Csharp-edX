using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear variables de diferentes tipos de datos
            // inicializar con un valor "predeterminado"
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Asignar algunos valores
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1932, 6, 1);

            // salida en la ventana de la consola

            // usar salida simple solo con el nombre de la variable
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // usar el estilo marcador de posición(placeholder)
            Console.WriteLine("{0} years old.", age);

            // usar concatenación para la string
            Console.WriteLine(street + ", " + city + ", " + country);

            // usar interpolación de strings
            
            // NOTA: Esta linea de código funciona con Visual Studio 2015 o C# 6.0 y posteriores.
            // Si se está usando una versión anterior, entonces comentar esta linea.
            Console.WriteLine($"Born on {birthDate}"); ;
        }
    }
}
