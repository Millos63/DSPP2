using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructYEnum
{
    internal struct CCamion
    {
        double cupoCajas;
        double gasolina;

        public CCamion(double pCupoCajas, double pGasolina)
        {
            cupoCajas = pCupoCajas;
            gasolina = pGasolina;
        }

        public override string ToString()
        {
            return String.Format("Al camion le caben: " + cupoCajas + " Y le caben: " + gasolina + " Litros de gasolina \n");
        }

        public void CambiarCupo(CCamion cupo, double incremento)
        {
            cupo.cupoCajas += incremento;
        }
    }
}
