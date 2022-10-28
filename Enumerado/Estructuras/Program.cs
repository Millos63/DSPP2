using System;

namespace Estructuras
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            CEmpleado empleado1 = new CEmpleado(9000, 500);

            Console.WriteLine(empleado1);

            empleado1.CambiarSalario(empleado1, 500);

            Console.WriteLine(empleado1);
        }
    }
}
