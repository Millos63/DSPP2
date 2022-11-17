using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertando elementos en la pila");
            Stack<int> pila = new Stack<int>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);

            foreach(int num in pila)
            {
                Console.WriteLine(num);
            }

            foreach(int num in pila)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Eliminando elementos en la pila");
            while(pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
            }
        }
    }
}
