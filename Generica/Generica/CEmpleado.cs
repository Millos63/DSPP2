using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generica
{
    internal class CEmpleado
    {

        private double salario;

        public CEmpleado(double pSalario)
        {
            salario = pSalario;
        }

        public double getSalario()
        {
            return salario;
        }

    }
}
