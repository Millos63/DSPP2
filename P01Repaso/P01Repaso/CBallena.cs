using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CBallena: CMamifero
    {
        public CBallena(string pNombreBallena):base(pNombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Yo estoy nadando");
        }
    }
}
