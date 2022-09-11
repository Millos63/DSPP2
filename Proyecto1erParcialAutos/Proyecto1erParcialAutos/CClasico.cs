using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CClasico : CAuto
    {
        public void mecanicaFacil()
        {
            Console.WriteLine("Soy un auto más fácil de reparar, ya que mi motor no es tan complejo");
        }

        public CClasico(string nombreClasico) : base(nombreClasico)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Clasico: Soy un auto con mucha clase y elegancia. Suelo ser un auto de colección");
        }
    }
}
