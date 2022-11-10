using System;
using System.Collections.Generic;
using System.Text;

namespace GenericoRestricciones
{
    internal class CSecretaria : IParaEmpleados
    {
        private double salario;

        public CSecretaria(double pSalario)
        {
            salario = pSalario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
