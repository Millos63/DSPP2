using System;
using System.Collections.Generic; 

namespace QueueStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string leer = "";
            string nueva = "";
            Console.WriteLine("Bienvenido a la dispensadora inteligente de bebidas gaseosas");
            Console.WriteLine("Las bebidas disponibles son las siguientes");
            Stack<string> pila = new Stack<string>();
            pila.Push("Coca-cola");
            pila.Push("Sprite");
            pila.Push("Fanta");
            pila.Push("Pepsi");
            pila.Push("Boing");
            pila.Push("Gatorade");

            foreach (string bebida in pila)
            {
                Console.WriteLine(bebida);
            }

            while(leer != "2")
            {
                Console.WriteLine("Le gustaria agregar otra bebida?, 1.Si, 2.No");
                leer = Console.ReadLine();

                if (leer == "1")
                {
                    Console.WriteLine("Dime el nombre de la bebida");
                    nueva = Console.ReadLine();
                    pila.Push(nueva);

                    foreach (string bebida in pila)
                    {
                        Console.WriteLine(bebida);
                    }
                } 
            }

            Console.WriteLine("Hay 5 clientes esperando a comprar su bebida");
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("Armando");
            cola.Enqueue("Dariel");
            cola.Enqueue("Nadia");
            cola.Enqueue("Alvaro");
            cola.Enqueue("Rodrigo");

            foreach (string persona in cola)
            {
                Console.WriteLine(persona);
            }
            Console.WriteLine("Presione 1 para continuar");
            Console.ReadLine();

            while (cola != null)
            {
                
                Console.WriteLine("El cliente:{0}, compro: {1}", cola.Peek(), pila.Peek());
                cola.Dequeue();
                pila.Pop();

                Console.WriteLine("Presione 1 para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("-----No hay Clientes------");


        }
    }
}
