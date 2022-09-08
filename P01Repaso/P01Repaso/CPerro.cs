using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CPerro : CMamifero
    {

        public void ladrar()
        {
            Console.WriteLine("Yo ladro");
        }

        //Crear constructor para la subclase perro que reciba el parámetro del nombre
        public CPerro(String nombrePerro):base(nombrePerro)
        {

        }

        new public void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }
}
