using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGenericoRestricciones
{
    internal class CAlmacenJitomate<T> where T : IVentaDeJitomate
    {
        private int i = 0;
        private T[] datosVentas;

        public CAlmacenJitomate(int z)
        {
            datosVentas = new T[z];
        }

        public void agregar(T obj)
        {
            datosVentas[i] = obj;
            i++;
        }

        public T getVenta(int i)
        {
            return datosVentas[i];
        }

    }
}
