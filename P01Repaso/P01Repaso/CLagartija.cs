using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
   
    class CLagartija : CAAnimales
    {
        
        private string nombreReptil;

        public CLagartija(string nombre)
        {
            nombreReptil = nombre;
        }
           
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es " + nombreReptil);
        }

    }
}
