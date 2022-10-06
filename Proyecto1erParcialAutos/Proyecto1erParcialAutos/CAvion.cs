using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CAvion : CATipoTransporte
    {
        private string nombreAvion;

        public CAvion(string nombre)
        {
            nombreAvion = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del avión es: {0}", nombreAvion );
        }
    }
}
