using System;

namespace P02Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEmpleado miEmpleado1 = new CEmpleado(4800, 500);
            Console.WriteLine(miEmpleado1);
            miEmpleado1.cambiaSalario(miEmpleado1, 1000);
            Console.WriteLine(miEmpleado1);
            Console.ReadLine();
        }
    }
}
