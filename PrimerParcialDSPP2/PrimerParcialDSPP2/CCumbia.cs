using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDSPP2
{
    internal class CCumbia : CMusica
    {
        public void ladrar()
        {
            Console.WriteLine("Yo ladro");
        }

        //Crear constructor para la subclase perro que reciba el parámetro del nombre
        public CPerro(String nombrePerro) : base(nombrePerro)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

    }
}
