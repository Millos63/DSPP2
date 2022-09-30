using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Repaso
{
    internal class CMamifero : CAAnimales
    {

        public void cuidarDescendencia()
        {

        }

        //Creamos un campo de la clase de tipo string para almacenar el nombre del ser vivo 
        private string nombreSerVivo;

        //Constructor Explicito
        public CMamifero(string nombre)
        {
            nombreSerVivo = nombre;
        }


        //Cree un metodo getNombre, para que escriba en nombreSerVivo
        public override void getNombre()
        {
            Console.WriteLine("Nombre del mamifero es {0}", nombreSerVivo);
        }

        //Creamos metodo pensar
        public virtual void pensar()
        {
            Console.WriteLine("Soy un ser pensante");
        }


    }
}
