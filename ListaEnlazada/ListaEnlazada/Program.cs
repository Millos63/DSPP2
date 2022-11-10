using System;
using System.Collections.Generic;


namespace ListaEnlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach(int num in new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9})
            {
                numeros.AddLast(num);
            }

            //numeros.Remove(6);

            LinkedListNode<int> nodo2 = new LinkedListNode<int>(13);
            numeros.AddFirst(nodo2);

            /*foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }*/

            for(LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo=nodo.Next)
            {
                int num = nodo.Value;
                Console.WriteLine(num);
            }

            //ESTO LO AGREGAMOS
            //Copia tu listaligada a un arreglo

            int[] sArray = new int [numeros.Count];
            numeros.CopyTo(sArray, 0);

            foreach(int num in sArray)
            {
                Console.WriteLine(num);
            }

            

            //Borramos la lista ligada
            numeros.Clear();
            if (numeros != null)
            {
                Console.WriteLine("Se ha removido todo");
            }


            Console.ReadLine();
        }
    }
}
