using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum2
{
    internal class CEmpleado
    {

        double salario;
        double comi;


        public CEmpleado(comision ComisionEmpleado, double pSalario)
        {
            comi = (double)ComisionEmpleado;
            this.salario = pSalario;
        }

        public double getSalario()
        {
            return salario + comi;
        }
    }
}
