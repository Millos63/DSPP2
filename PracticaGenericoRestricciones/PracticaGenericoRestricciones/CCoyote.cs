using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CCoyote
    {
        private double comision;

        public CCoyote(double pComision)
        {
            comision = pComision;
        }

        public double getComision()
        {
            return comision;
        }
    }
}
