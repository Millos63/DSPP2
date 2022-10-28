using System;
using System.Collections.Generic;
using System.Text;

namespace P02Repaso
{

    //Ejemplo de struct
    internal struct CEmpleado
    {
        private double salarioBase;
        private double comision;

        public CEmpleado(double pSalarioBase, double pComision)
        {
            //El this lo ocupamos para ver cual es el campo, el otro seria el parametro.
            salarioBase = pSalarioBase;
            comision = pComision;
        }

        public override string ToString()
        {
            return string.Format ("SalarioBase: " + salarioBase + " Comision: " + comision);
        }

        public void cambiaSalario(CEmpleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
