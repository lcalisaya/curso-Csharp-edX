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
            bool creditsRequired = Console.ReadLine();
        }
            
           

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} nació el: {2}", first, last, birthday);
        }
    }
}
