using System;

namespace GenericoRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAlmacenEmpleados<CEstudiante> empleados = new CEstudiante<CEstudiante>(3);
            empleados.agregar(new CEstudiante(7000));
            empleados.agregar(new CEstudiante(5000));
            empleados.agregar(new CEstudiante(4500));

        }

       
    }
}
