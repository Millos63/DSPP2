using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancias de cada una de las clases

            //Instancia de la clase CHumano
            CHumano miHumano = new CHumano("Emigdio");
            
            //Instancia de la clase CPerro
            CPerro miPerro = new CPerro("Manchas");

            //Instancia de la clase CChango
            CChango miChango = new CChango("Marango");

            //Instancia de la clase CMamifero
            CMamifero miMamifero = new CMamifero("Chango");

            //instancia de la clase CCaballo
            //Creamos un objeto de CCaballo llamado miCaballo

            CCaballo miCaballo = new CCaballo("vayita");

            //Para mandar a llamar getNombre
            miHumano.getNombre();
            miPerro.getNombre();
            miChango.getNombre();

            IMamiferosTerrestres IMiCa = miCaballo;
            IMamiferosTerrestres IMiCa2 = miCaballo; 

            //arreglo con 3 elementos "Program"
            CMamifero[] arregloAnimales = new CMamifero[3];
            arregloAnimales[0] = miPerro;
            arregloAnimales[1] = miHumano;
            arregloAnimales[2] = miChango;

            arregloAnimales[1].pensar();
            Console.WriteLine("---------------");

            for (int i = 0; i < 3 ; i++)
            {
                arregloAnimales[i].pensar();
            }

            CBallena miBallena = new CBallena("Mobidic");
            miBallena.nadar();

            Console.WriteLine("Numero de patas de pinto: " + IMiCa.NumeroPatas());
            Console.WriteLine("El caballo se utiliza en el deporte: "+ miCaballo.TipoDeporte());

            //////////////
            ///

            //Creamos objeto de la clase CLagartija

            CLagartija miLagartija = new CLagartija("Tija");
            CPerro miPerro2 = new CPerro("Manchas");
            miLagartija.getNombre();
            miPerro2.getNombre();

           

            
        }
    }
}
