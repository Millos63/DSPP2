using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CCentralDeAbastos : IVentaDeJitomate
    {
        private double precio;

        public CCentralDeAbastos(double pPrecio)
        {
            precio = pPrecio;
        }

        public double getPrecio()
        {
            return precio;
        }
    }
}

