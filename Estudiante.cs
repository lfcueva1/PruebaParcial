using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Prueba1
{
    internal class Estudiante
    {
        //EJERCICIO 3
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }


        //EJERCICIO 4
        //Amplio la clase con el siguiente metodo:
        //UTILICE EL TERMINO "VIRTUAL" en la funcion para que este metodo pueda funcionar en
        //otras clases que herede la clase estudiante
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Información del estudiante:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Calificación: {Calificacion}");
        }


    }
}
