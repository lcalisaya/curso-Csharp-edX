using System;

namespace Mod3_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string firstNameStudent;
            string lastNameStudent;
            DateTime birthDateStudent;
            
            string firstNameTeacher;
            string lastNameTeacher;
            DateTime birthDateTeacher;

            string courseName; 
            string credits; 
            int durationInweeks; 
            string teacher;

            string programName; 
            string departmentHead; 
            string degrees;

            string degreeName; 
            bool creditsRequired;

            //Se llama a cada uno de los métodos que solicitan datos al Usuario/a
            GetStudentInformation(out firstNameStudent, out lastNameStudent, out birthDateStudent);
            try
            {
                ValidateStudentBirthday();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            GetTeacherInformation(out firstNameTeacher, out lastNameTeacher, out birthDateTeacher);
            GetCourseInformation(out courseName, out credits, out durationInweeks, out teacher);
            GetUProgramInformation(out programName, out departmentHead, out degrees);
            GetDegreeInformation(out degreeName, out creditsRequired);

            // Se llama a cada uno de los métodos que imprimirá en pantalla los datos requeridos
            PrintStudentDetails(firstNameStudent, lastNameStudent, birthDateStudent);
            PrintTeacherDetails(firstNameTeacher, lastNameTeacher, birthDateTeacher);
            PrintCourseDetails(courseName, credits, durationInweeks, teacher);
            PrintUProgramDetails(programName, departmentHead, degrees);
            PrintDegreeDetails(degreeName, creditsRequired);
        }

        // Métodos que obtienen la información que ingresa el Usuario/a
        static void GetStudentInformation(out string firstName, out string lastName, out DateTime birthDate)
        {
            Console.WriteLine("Ingrese el Nombre del Estudiante:");
            firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Estudiante:");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del Estudiante con formato dd/mm/aaaa:");
            birthDate = Convert.ToDateTime(Console.ReadLine());
        }

        static void GetTeacherInformation(out string firstName, out string lastName, out DateTime birthDate)
        {
            Console.WriteLine("Ingrese el Nombre del Profesor:");
            firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido del Profesor:");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del Profesor con formato dd/mm/aaaa:");
            birthDate = Convert.ToDateTime(Console.ReadLine());
        }

        static void GetCourseInformation(out string courseName, out string credits, out int durationInweeks, out string teacher)
        {
            Console.WriteLine("Ingrese el nombre del curso:");
            courseName = Console.ReadLine();
            Console.WriteLine("Ingrese los créditos del curso:");
            credits = Console.ReadLine();
            Console.WriteLine("Ingrese la duración en semanas del curso:");
            durationInweeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el profesor del curso:");
            teacher = Console.ReadLine();
        }

        static void GetUProgramInformation(out string programName, out string departmentHead, out string degrees)
        {
            Console.WriteLine("Ingrese el nombre del programa:");
            programName = Console.ReadLine();
            Console.WriteLine("Ingrese el jefe del departamento:");
            departmentHead = Console.ReadLine();
            Console.WriteLine("Ingrese los títulos:");
            degrees = Console.ReadLine();
        }

        static void GetDegreeInformation(out string degreeName, out bool creditsRequired)
        {
            Console.WriteLine("Ingrese el nombre del título:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Ingrese 'true' si el título tiene créditos requeridos. Caso contrario, ingrese'false':");
            creditsRequired = Convert.ToBoolean(Console.ReadLine());
        }

        static void ValidateStudentBirthday()
        {
            throw new NotImplementedException();
        }
            
           
        // Métodos que imprimen en pantalla la información que ingresó el Usuario/a
        static void PrintStudentDetails(string first, string last, DateTime birth)
        {
            Console.WriteLine("{0} {1} es Estudiante y nació el {2}", first, last, birth.ToString("dd/MM/yyyy"));
        }

        static void PrintTeacherDetails(string first, string last, DateTime birth)
        {
            Console.WriteLine("{0} {1} es Profesor y nació el {2}", first, last, birth.ToString("dd/MM/yyyy"));
        }

        static void PrintCourseDetails(string courseName, string credits, int durationInweeks, string teacher)
        {
            Console.WriteLine("El nombre del curso: {0} -- Los créditos del curso: {1} -- El curso dura {2} semanas -- El profesor es: {3}", courseName, credits, durationInweeks.ToString(), teacher);
        }

        static void PrintUProgramDetails(string programName, string departmentHead, string degrees)
        {
            Console.WriteLine("Nombre del programa: {0} -- Jefe del Departamento: {1} -- Títulos: {2}", programName, departmentHead, degrees);
        }

        static void PrintDegreeDetails(string degreeName, bool creditsRequired)
        {
            Console.WriteLine("Nombre del título: {0} -- Créditos requeridos: {1}", degreeName, creditsRequired.ToString());
        }
    }
}
