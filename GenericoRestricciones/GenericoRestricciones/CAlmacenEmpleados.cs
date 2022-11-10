using System;
using System.Collections.Generic;
using System.Text;

namespace GenericoRestricciones
{
    internal class CAlmacenEmpleados<T> where T : IParaEmpleados
    {
        private int i = 0;

        private T[] datosEmpleados;

        public CAlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void agregar(T obj)
        {
            datosEmpleados[i++] = obj;
            i++;
        }

        public T getEmpleados(int i)
        {
            return datosEmpleados[i];
        }

        
    }
}
