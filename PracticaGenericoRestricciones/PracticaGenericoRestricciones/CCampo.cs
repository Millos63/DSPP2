using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CCampo : IVentaDeJitomate
    {
        private double precio;

        public CCampo(double pPrecio)
        {
            precio = pPrecio;
        }

        public double getPrecio()
        {
            return precio;
        }
    }
}
