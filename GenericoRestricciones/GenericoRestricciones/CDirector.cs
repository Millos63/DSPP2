using System;
using System.Collections.Generic;
using System.Text;

namespace GenericoRestricciones
{
    internal class CDirector : IParaEmpleados
    {
        //Campo de clase
        private double salario;

        public CDirector(double pSalario)
        {
            salario = pSalario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
}
