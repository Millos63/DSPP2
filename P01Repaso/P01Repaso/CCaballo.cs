using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CCaballo : CMamifero, IMamiferosTerrestres, IAnimalesEnDeportes, ISaltoConPatas
    {
        public CCaballo(string pNombreCaballo):base(pNombreCaballo)
        {

        }

        public void bailar()
        {
            Console.WriteLine("Yo se bailar");
        }

        public override void pensar()
        {
            Console.WriteLine("Tambien pienso un poco");
        }

        /*public int NumeroPatas()
        {
            return 4;
        }*/

        public string TipoDeporte()
        {
            return "Charreria";
        }
        public Boolean EsOlimpico()
        {
            return false;
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }
}
