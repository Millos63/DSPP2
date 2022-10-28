using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generica
{
    internal class CAlmacenObjetos<T>
    {
        private T [] datoElementos;
        private int i = 0;
        public CAlmacenObjetos(int z)
        {
            datoElementos = new T [z];
        }

        public void agregar(T obj)
        {
            datoElementos[i] = obj;
            i++;    
        }

        public T getElementos(int i)
        {
            return datoElementos[i];
        }
    }
}
