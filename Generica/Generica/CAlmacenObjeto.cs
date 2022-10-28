using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generica
{
    internal class CAlmacenObjeto
    {
        private object[] datoElementos;
        private int i = 0;
        public CAlmacenObjeto(int z)
        {
            datoElementos = new object[z];
        }

        public void agregar(object obj)
        {
            datoElementos[i] = obj;
            i++;    
        }

        public object getElemento(int i)
        {
            return datoElementos[i];
        }
    }
}
