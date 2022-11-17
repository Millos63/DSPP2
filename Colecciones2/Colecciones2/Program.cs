using System;
using System.Collections.Generic;

namespace Colecciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando la lista (coleccion de tipo list)
            List<int> numeros = new List<int>();
            int elem = 1;
            //2DA forma de hacerlo
            Console.WriteLine("introduce elementos en la collecion < 0 para salir > ");

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());
                numeros.Add(elem); 
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Los elementos que introdujo son: ");
            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }


            Console.WriteLine("Aqui haremos una copia de nuestra lista en un arreglo");
            
            ////CopyTo
            int[] arrayClon = new int[numeros.Count];
            numeros.CopyTo(arrayClon, 0);

            foreach(int num in arrayClon)
            {
                Console.WriteLine(num);
            }


            /*Console.WriteLine("Cuantos elementos desea introducir?");
            
            //Para convertir lo que se lee en entero mas rapido 
            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i<elem; i++)
            {
                Console.WriteLine("Dime el dato");
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Imprimiento los elementos");
            for(int i = 0; i<numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/
        }
    }
}
