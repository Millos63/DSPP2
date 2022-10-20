using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CAdolescente : CHumano
    {
        public CAdolescente(string pNombreAdolescente):base(pNombreAdolescente)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Mis hormonas piensan por mi");
        }
    }
}
