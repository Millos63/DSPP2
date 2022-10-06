using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    //Esta sera la superclase
    internal class CAuto : CATipoTransporte
    {

        private string nombreAuto;
        public void neumaticos()
        {
            Console.WriteLine("Tiene cuatro neumaticos");
        }

        

        //Constructor explicito
        public CAuto(string nombre)
        {
            nombreAuto = nombre; 
        }

        public override void getNombre()
        {
            Console.WriteLine("Ejemplo: {0}", nombreAuto);

        }

        public virtual void caracteristicas()
        {
            Console.WriteLine("Caracteristicas principales del auto ");
        }

        
    }
}
