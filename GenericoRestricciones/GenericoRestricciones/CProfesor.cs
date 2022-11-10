using System;
using System.Collections.Generic;
using System.Text;

namespace GenericoRestricciones
{
    internal class CProfesor : IParaEmpleados
    {
        private double salario;

        public CProfesor(double pSalario)
        {
            salario = pSalario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
