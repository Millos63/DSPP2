using System;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            //Agregando elementos

            numeros.Add(7);
            numeros.Add(13);
            numeros.Add(21);

            //Recorriendo la lista
            for(int i = 0; i < 3 ; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            int[] listaNumeros = new int[] { 23, 25, 27, 32, 35 };

            for(int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            //Recorriendo la lista para imprimirla
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();
        }
    }
}
