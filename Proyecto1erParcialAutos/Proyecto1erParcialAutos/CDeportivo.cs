using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class CDeportivo : CAuto, IVelocidad, ITransmision
    {
        public void frenadoABS()
        {
            Console.WriteLine("Tengo frenado ABS para poder detener el auto a gran velocidad");
        }   

        public CDeportivo(string nombreDeportivo):base(nombreDeportivo)
        {

        }

        public override void caracteristicas()
        {
            Console.WriteLine("Deportivo:Son autos muy veloces, llamativos y muy caros.");
        }



        //Metodo que implementa la interfaz IVelocidad
        public int CaballosDeFuerza()
        {
            return 500;
        }

        //Metodo que implementa la interfaz IVelocidad
        public int KilometrosPorHora()
        {
            return 400; 
        }

        //Metodo que implementa la interfaz ITransmision
        public string Transmision()
        {
            return "Automatica";
        }
        
        //Metodo que implementa la interfaz ITransmision
        public Boolean EsTiptronic()
        {
            return true;
        }


       
    }
}
