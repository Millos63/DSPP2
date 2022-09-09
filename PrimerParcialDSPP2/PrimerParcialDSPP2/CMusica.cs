using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialDSPP2
{
    //Esta es la clase padre
    internal class CMusica
    {
        public void expresion()
        {
            Console.WriteLine("Este genero suele expresar algun sentimiento");
        }

        //Creamos un campo de la clase de tipo string para almacenar el nombre de la cancion
        private string nombreCancion;

        //Constructor Explicito
        public CMusica(string nombre)
        {
            nombreCancion = nombre;
        }


        //Cree un metodo getNombre, para que escriba en nombreCancion
        public void getNombre()
        {
            Console.WriteLine("Nombre de la cancion {0}", nombreCancion);
        }

        //Creamos metodo seBaila
        public virtual void seBaila()
        {
            Console.WriteLine("En este genero musical es posible que se pueda bailar");
        }
    }
}
