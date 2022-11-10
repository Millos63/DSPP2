using System;

namespace GenericoRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAlmacenEmpleados<CProfesor> empleados = new CAlmacenEmpleados<CProfesor>(3);
            empleados.agregar(new CProfesor(7000));
            empleados.agregar(new CProfesor(5000));
            empleados.agregar(new CProfesor(4500));

        }

       
    }
}
