using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CDeportivo : CAuto
    {
        public void frenadoABS()
        {
            Console.WriteLine("Tengo frenado ABS para poder detener el auto a gran velocidad");
        }   

        public CDeportivo(string nombreDeportivo):base(nombreDeportivo)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Deportivo:Son autos muy velozes, llamativos y muy caros.");
        }
    }
}
