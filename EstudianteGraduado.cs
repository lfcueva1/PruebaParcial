using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Prueba1
{
    internal class EstudianteGraduado:Estudiante
    {
        //EJERCICIO 5
        public string Titulo { get; set; }

        // Método para mostrar la información del estudiante graduado
        public override void MostrarInformacion()
        {
            // Llama al método de la clase base para mostrar la información del estudiante
            base.MostrarInformacion();
            Console.WriteLine($"Título : {Titulo}");
        }
    }
}
