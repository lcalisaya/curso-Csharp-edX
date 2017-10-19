using System;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Information
            string firstNameStudent;
            string lastNameStudent;
            DateTime birthdateStudent;	
            string address1Student;	
            string address2Student;	
            string cityStudent;
            string stateOrProvinceStudent;	
            string zipOrPostalStudent;	
            string countryStudent;

            //Teacher Information
            string firstNameTeacher;
            string lastNameTeacher;
            DateTime birthdateTeacher;	
            string address1Teacher;	
            string address2Teacher;	
            string cityTeacher;
            string stateOrProvinceTeacher;	
            string zipOrPostalTeacher;	
            string countryTeacher;

            //UProgram Information
            string programName;	
            string departmentHead;
            string degrees;

            //Degree Information
            string degreeName;
            bool creditsRequired;

            //Course Information
            string courseName;
            string credits;
            int	durationInweeks;
            string teacher;

            //Usar asignaciones para darles un valor a cada variable - por el Usuario

            Console.WriteLine("Ingrese nombre del estudiante:");
            firstNameStudent = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del estudiante:");
            lastNameStudent = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento del estudiante con formato dd/mm/aaaa:");
            birthdateStudent = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese dirección 1 del estudiante:");
            address1Student = Console.ReadLine();
            Console.WriteLine("Ingrese dirección 2 del estudiante:");
            address2Student = Console.ReadLine();
            Console.WriteLine("Ingrese ciudad del estudiante:");
            cityStudent = Console.ReadLine();
            Console.WriteLine("Ingrese provincia del estudiante:");
            stateOrProvinceStudent = Console.ReadLine();
            Console.WriteLine("Ingrese código postal del estudiante:");
            zipOrPostalStudent = Console.ReadLine();
            Console.WriteLine("Ingrese país del estudiante:");
            countryStudent = Console.ReadLine();

            firstNameTeacher = "Gabriel";
            lastNameTeacher = "Fernández";
            birthdateTeacher = new DateTime(1980, 09, 28);	
            address1Teacher = "Sudamérica 7361";
            address2Teacher = null;
            cityTeacher = "Parána";
            stateOrProvinceTeacher = "Entre Ríos";
            zipOrPostalTeacher = "1903";
            countryTeacher = "Argentina";

            programName = "Educación en TI para jóvenes";
            departmentHead = "Silvana Rodriguez";
            degrees = "Ciencias de la Educación";

            degreeName = "Capacitación en TI";
            creditsRequired = false;

            courseName = "Introducción a Java";
            credits = "Cintia Pacheco, Carlos Gregorio y Fernando Urbano";
            durationInweeks = 16;
            teacher = "Patricia Hernández";

            Console.WriteLine("*Datos del Estudiante");
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Fecha de nacimiento: {2}, Dirección1: {3}, Dirección2: {4}, Ciudad: {5}, Provincia: {6}, Código Postal: {7}, País: {8}", 
            firstNameStudent, lastNameStudent, birthdateStudent, address1Student, address2Student, cityStudent, stateOrProvinceStudent, zipOrPostalStudent, countryStudent);

            Console.WriteLine("*Datos del Profesor");
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Fecha de nacimiento: {2}, Dirección1: {3}, Dirección2: {4}, Ciudad: {5}, Provincia: {6}, Código Postal: {7}, País: {8}", 
            firstNameTeacher, lastNameTeacher, birthdateTeacher, address1Teacher, address2Teacher, cityTeacher, stateOrProvinceTeacher, zipOrPostalTeacher, countryTeacher);

            Console.WriteLine("*Información del Programa");
            Console.WriteLine("Nombre del Programa: {0}, Jefe del departamento: {1}, Títulos: {2}", programName, departmentHead, degrees);
            
            Console.WriteLine("*Información del título");
            Console.WriteLine("Nombre del título: " + degreeName + ", Créditos requeridos: " + creditsRequired);
            
            Console.WriteLine("*Información del curso");
            Console.WriteLine("Nombre del curso: {0}, Créditos: {1}, Duración en semanas: {2}, Profesor: {3}", courseName, credits, durationInweeks, teacher);
            
        }
    }
}
