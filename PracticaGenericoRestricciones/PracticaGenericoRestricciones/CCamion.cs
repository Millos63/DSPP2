using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CCamion : IVentaDeJitomate
    {
        private double precio;

        public CCamion(double pPrecio)
        {
            precio = pPrecio;   
        }

        public double getPrecio()
        {
            return precio;
        }

    }
}
