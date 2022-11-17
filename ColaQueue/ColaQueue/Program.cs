using System;
using System.Collections.Generic;

namespace ColaQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>();
            Console.WriteLine("Insertando");
            cola.Enqueue(23);
            cola.Enqueue(35);
            cola.Enqueue(13);
            cola.Enqueue(7);
            foreach(int num in cola)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("ELIMINANDO");
            while(cola.Count > 0)
            {
                Console.WriteLine(cola.Dequeue());
            }
            Console.ReadLine(); 
        }
    }
}
