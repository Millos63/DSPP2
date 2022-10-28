using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CManejoArchivos miArchivo = new CManejoArchivos();

            miArchivo.mensaje();
            Console.ReadLine();
        }
    }

    internal class CManejoArchivos
    {
        int contador = 0;
        string linea;
        StreamReader archivo = null;
        public CManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Armando\texto.txt");
            //Va a leer informacion, va a aumentar a contador, y se va a detener al encontrar un valor null, o sea en blanco
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("Hay {0} lineas en el archivo", contador);
        }


        //Es como el metodo constructor, este es para eliminar los archivos basura, elimina la tilde.
        ~CManejoArchivos()
        {
            archivo.Close();
        }
    }


}
