using System;

namespace Mod3_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        // Métodos que obtienen la información que ingresa el Usuario/a
        static void GetStudentInformation()
        {
            Console.WriteLine("Ingrese en Nombre del Estudiante:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Estudiante:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del Estudiante con formato dd/mm/aaaa:");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Ingrese en Nombre del Profesor:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Profesor:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del Profesor con formato dd/mm/aaaa:");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Ingrese el nombre del curso:");
            string courseName = Console.ReadLine();
            Console.WriteLine("Ingrese los créditos del curso:");
            string credits = Console.ReadLine();
            Console.WriteLine("Ingrese la duración en semanas del curso:");
            int	durationInweeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el profesor del curso:");
            string teacher = Console.ReadLine();
        }

        static void GetUProgramInformation()
        {
            Console.WriteLine("Ingrese el nombre del programa:");
            string programName = Console.ReadLine();
            Console.WriteLine("Ingrese el jefe del departamento:");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Ingrese los títulos:");
            string degrees = Console.ReadLine();
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Ingrese el nombre del título:");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Ingrese los créditos requeridos:");
            bool creditsRequired = Convert.ToBoolean(Console.ReadLine());
        }
            
           
        // Métodos que imprimen en pantalla la información que ingresó el Usuario/a
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} es Estudiantes y nació el: {2}", first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} es Profesor y nació el: {2}", first, last, birthday);
        }

        static void PrintCourseDetails(string courseName, string credits, string durationInweeks, string teacher)
        {
            Console.WriteLine("El nombre del curso: {0} -- Los créditos del curso: {1} -- El curso dura {2} semanas -- El profesor es: {3}", courseName, credits, durationInweeks, teacher);
        }

        static void PrintUProgramDetails(string programName, string departmentHead, string degrees)
        {
            Console.WriteLine("Nombre del programa: {0} -- Jefe del Departamento: {1} -- Títulos: {2}", programName, departmentHead, degrees);
        }

        static void PrintDegreeDetails(string degreeName, string creditsRequired)
        {
            Console.WriteLine("Nombre del título: {0} -- Créditos requeridos: {1}", degreeName, creditsRequired);
        }

    }
}
