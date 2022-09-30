using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    //Clase abstracta
    abstract class CAAnimales
    {
        public void respirar()
        {
            Console.WriteLine("Tengo la capacidad de respirar");
        }

        public abstract void getNombre();
    }
}
