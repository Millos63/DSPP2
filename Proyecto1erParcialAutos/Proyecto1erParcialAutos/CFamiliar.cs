using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CFamiliar : CAuto, IVelocidad, ITransmision
    {
        public void espacio()
        {
            Console.WriteLine("Soy un coche con mucho espacio");
        }

        public CFamiliar(string nombreFamiliar) : base(nombreFamiliar)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Familiar: Soy un auto muy comodo, para viajes largos con toda la familia");
        }

        //Metodo que implementa la interfaz IVelocidad
        public int CaballosDeFuerza()
        {
            return 300;
        }

        //Metodo que implementa la interfaz IVelocidad
        public int KilometrosPorHora()
        {
            return 150;
        }

        //Metodo que implementa la interfaz ITransmision
        public string Transmision()
        {
            return "Automatica";
        }

        //Metodo que implementa la interfaz ITransmision
        public Boolean EsTiptronic()
        {
            return false;
        }
    }
}
