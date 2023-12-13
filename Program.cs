using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1
            // Declaracion de las variables numero1 y numero2
            int numero1 = 51;
            int numero2 = 22;

            int resultado = 0;

            //calculo la suma de numero1 y numero 2 en la variable resultado
            resultado = numero1 + numero2;
            Console.WriteLine("EJERCICIO 1\n");
            // Imprimir en la consola el valor de resultado
            Console.WriteLine($"La suma de {numero1} y {numero2} es: {resultado}");

            //EJERCICIO2
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 2\n");
            //declaro la variable edad
            int edad = 22;
            //si la variable edad es un numero mayor o igual a 18 entonces es mayor de edad, caso contrario es menor de edad
            if (edad >= 18){
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted no es mayor de edad");
            }


            //EJERCICIO 3
            // Hago la creacion del objeto
            Estudiante estudiante1 = new Estudiante();

            // InicializO las propiedades del estudiante con valores ficticios
            estudiante1.Nombre = "Luis Fernando Cueva Flores";
            estudiante1.Edad = 22;
            estudiante1.Calificacion = 20;
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 3\n");
            // Imprimir en la consola la información del estudiante
            Console.WriteLine("Información del estudiante:");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad} años");
            Console.WriteLine($"Calificación: {estudiante1.Calificacion}");

            //EJERCICIO 4
            // Hago la creacion del objeto
            Estudiante estudiante2 = new Estudiante();
            // InicializO las propiedades del estudiante con valores ficticios
            estudiante2.Nombre = "Esteban Andres Cueva Flores";
            estudiante2.Edad = 18;
            estudiante2.Calificacion = 19;
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 4\n");
            // Llamar al método MostrarInformacion para el objeto estudiante1
            estudiante2.MostrarInformacion();

            //EJERCICIO 5
            // Hago la creacion del objeto
            EstudianteGraduado estudiante3 = new EstudianteGraduado();
            // InicializO las propiedades del estudiante con valores ficticios
            estudiante3.Nombre = "Jefferson Efren Cueva Flores";
            estudiante3.Edad = 28;
            estudiante3.Calificacion = 18;
            estudiante3.Titulo = "Ingenieria en Software";
            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 5\n");
            // Llamar al método MostrarInformacion para el objeto estudiante1
            estudiante3.MostrarInformacion();
        }
    }
}

