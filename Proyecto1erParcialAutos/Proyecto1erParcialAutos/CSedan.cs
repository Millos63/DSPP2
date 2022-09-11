using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CSedan : CAuto
    {
        public void estable()
        {
            Console.WriteLine("Tiene una conducción estable y comoda gracias a la distribución del peso.");
        }

        public CSedan(string nombreSedan) : base(nombreSedan)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Sedan: Son la perfecta combinación entre comodidad, seguridad y deportivismo");
        }
    }
}
