using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la clase
            CAlmacenObjetos <string> info = new CAlmacenObjetos<string>(3);

            info.agregar("Lety");
            info.agregar("Diego");
            info.agregar("Karla");


            //info.agregar(new CEmpleado(3000));
            //info.agregar(new CEmpleado(4000));
            //info.agregar(new CEmpleado(5000));



             

            //string nombrePersona = (string)info.getElemento(3);

            //Console.WriteLine(nombrePersona);

            String salarioEmpleado = info.getElementos(2);
            Console.WriteLine(salarioEmpleado);


            //Esta es la otra version
        }   
    }
}

