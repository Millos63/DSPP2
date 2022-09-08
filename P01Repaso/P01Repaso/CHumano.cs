using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CHumano : CMamifero 
    {
        //Con la palabra new, ocultamos el de la clase padre, osea mamifero y ocupamos el de la clase CHumano.
        new public void pensar()
        {
            Console.WriteLine("Yo pienso");
        }

        //Constructor para CHumano
        public CHumano(String nombreHumano):base(nombreHumano)
        {

        }
    }
}
