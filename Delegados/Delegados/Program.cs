using System;

namespace Delegados
{
    internal class Program
    {
        delegate void objetoDelegado(string msj);
        static void Main(string[] args)
        {
            //Creamos el objeto delegado que apunta a la clase MensajeBienvenida 
            objetoDelegado miDelegado = new objetoDelegado(MensajeBienvenida.saludoBienvenida);

            //Utilización de delegado para llamar al metodo saludoBienvenida
            miDelegado("Hola estimados estudiantes");

            Console.ReadLine();

            objetoDelegado miDelegado2 = new objetoDelegado(MensajeDespedida.saludoDespedida);
            miDelegado2("Bye estimados estudiantes");
            Console.ReadLine();
        }
    }

    class MensajeBienvenida
    {
        public static void saludoBienvenida(string msj)
        {
            Console.WriteLine("Hola estimados estudiantes, sean bienvenidos"); 
        }
    }

    class MensajeDespedida
    {
        public static void saludoDespedida(string msj)
        {
            Console.WriteLine("Bye estimados estudiantes, bonito dia");
        }
    }
}
