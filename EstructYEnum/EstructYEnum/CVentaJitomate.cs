using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructYEnum
{
    internal class CVentaJitomate
    {
        double precioJitomate;
        double conten;

        public CVentaJitomate(contenedor pContenedor, double pPrecioJitomate)
        {
            conten = (double)pContenedor;
            precioJitomate = pPrecioJitomate;
        }

        public double getPrecioTotal()
        {
            return precioJitomate + conten;
        }
    }
}
