using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerado
{
    //Lo habitual es que se declare aquí el tipo enum para que todos la puedan ocupar
    enum estaciones { Primavera, Verano, Otoño, Invierno};
    internal class Program
    {
        static void Main(string[] args)
        {
            estaciones preferida = estaciones.Invierno;
            Console.WriteLine(preferida);

            string miEstacion = preferida.ToString();
            Console.WriteLine(miEstacion);
            Console.ReadLine();

            //Para guardar valores nulos en un enumerado:
            estaciones? vacia = null;
        }
    }
}
