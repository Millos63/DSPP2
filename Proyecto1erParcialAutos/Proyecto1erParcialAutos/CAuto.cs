using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    //Esta sera la superclase
    internal class CAuto
    {

        private string nombreAuto;
        public void neumaticos()
        {
            Console.WriteLine("Tiene cuatro neumaticos");
        }

        public void motor()
        {
            Console.WriteLine("Tiene motor");
        }

        //Constructor explicito
        public CAuto(string nombre)
        {
            nombreAuto = nombre; 
        }

        public void getNombre()
        {
            Console.WriteLine("Ejemplo: {0}", nombreAuto);

        }

        public virtual void caracteristicas()
        {
            Console.WriteLine("Caracteristicas principales del auto ");
        }

        
    }
}
