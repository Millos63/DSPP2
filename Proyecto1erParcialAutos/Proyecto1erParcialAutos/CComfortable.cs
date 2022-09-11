using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CComfortable : CAuto
    {
        public void espacio()
        {
            Console.WriteLine("Soy un coche con mucho espacio");
        }

        public CComfortable(string nombreDeportivo) : base(nombreDeportivo)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Soy un auto muy comodo, familiar, por lo regular me utilizan para llevar a toda la familia y para viajes largos ");
        }
    }
}
