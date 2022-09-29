using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CPerro : CMamifero, IMamiferosTerrestres
    {

        public void ladrar()
        {
            Console.WriteLine("Yo ladro");
        }

        //Crear constructor para la subclase perro que reciba el parámetro del nombre
        public CPerro(String nombrePerro):base(nombrePerro)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public int NumeroPatas()
        {
            return 4;
        }
        
        
    }
}
