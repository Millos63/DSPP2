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
            //pila.Push("Pepsi");
            //pila.Push("Boing");
            //pila.Push("Gatorade");

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


            int numPersona = 0;
            while (numPersona < cola.Count )
            {
                if (pila.Count > 0)
                {
                    Console.WriteLine("El cliente: {0}", cola.Dequeue());
                    Console.WriteLine("Compro: {0} ", pila.Pop());
                    Console.WriteLine("Presione 1 para continuar");
                    Console.ReadLine();
                }
                if(pila.Count == 0)
                {
                    Console.WriteLine("------La maquina expendedora se ha quedado sin bebidas, deseas agregar mas bebidas?");
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
                    else if (leer == "2")
                    {
                        numPersona = cola.Count;
                        Console.WriteLine("Vuelva pronto ya no hay bebidas y no se agregaran mas");
                    }
                }               
            }

            if(cola.Count == 0)
            {
                Console.WriteLine("-----No hay Clientes------");
            }
            

        }
    }
}
