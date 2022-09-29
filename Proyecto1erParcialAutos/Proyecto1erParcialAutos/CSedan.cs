using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CSedan : CAuto, IVelocidad, ITransmision
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

        //Metodo que implementa la interfaz IVelocidad
        public int CaballosDeFuerza()
        {
            return 300;
        }

        //Metodo que implementa la interfaz IVelocidad
        public int KilometrosPorHora()
        {
            return 190;
        }

        //Metodo que implementa la interfaz ITransmision
        public string Transmision()
        {
            return "automatica";
        }

        //Metodo que implementa la interfaz ITransmision
        public Boolean EsTiptronic()
        {
            return true;
        }
    }
}
