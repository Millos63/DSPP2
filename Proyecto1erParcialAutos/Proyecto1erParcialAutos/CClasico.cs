using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CClasico : CAuto, IVelocidad, ITransmision
    {
        public void mecanicaFacil()
        {
            Console.WriteLine("Son autos más fáciles de reparar, ya que mi motor no es tan complejo");
        }

        public CClasico(string nombreClasico) : base(nombreClasico)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Clasico: Soy un auto con mucha clase y elegancia. Suelo ser un auto de colección");
        }

        //Metodo que implementa la interfaz IVelocidad
        public int CaballosDeFuerza()
        {
            return 200;
        }

        //Metodo que implementa la interfaz IVelocidad
        public int KilometrosPorHora()
        {
            return 120;
        }

        //Metodo que implementa la interfaz ITransmision
        public string Transmision()
        {
            return "manual";
        }

        //Metodo que implementa la interfaz ITransmision
        public Boolean EsTiptronic()
        {
            return false;
        }

    }
}
