using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CFamiliar : CAuto
    {
        public void espacio()
        {
            Console.WriteLine("Soy un coche con mucho espacio");
        }

        public CFamiliar(string nombreFamiliar) : base(nombreFamiliar)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Familiar: Soy un auto muy comodo, para viajes largos con toda la familia");
        }
    }
}
