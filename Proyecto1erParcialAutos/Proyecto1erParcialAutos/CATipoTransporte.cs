using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    //Clase abstracta
    abstract class CATipoTransporte
    {
        public void motor()
        {
            Console.WriteLine("Tiene motor");
        }
        public abstract void getNombre();
    }
}
