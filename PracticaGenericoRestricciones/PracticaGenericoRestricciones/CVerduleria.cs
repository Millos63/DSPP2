using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CVerduleria : IVentaDeJitomate
    {
        private double precio;

        public CVerduleria(double pPrecio)
        {
            precio = pPrecio;
        }

        public double getPrecio()
        {
            return precio;
        }
    }
}
