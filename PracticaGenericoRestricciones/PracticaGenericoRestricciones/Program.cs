using System;

namespace PracticaGenericoRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables para trabajar
            string leer = "";

            CAlmacenJitomate<CCampo> ventas = new CAlmacenJitomate<CCampo>(3);
            CAlmacenJitomate<CCamion> ventas2 = new CAlmacenJitomate<CCamion>(3);
            CAlmacenJitomate<CCentralDeAbastos> ventas3 = new CAlmacenJitomate<CCentralDeAbastos>(3);
            CAlmacenJitomate<CVerduleria> ventas4 = new CAlmacenJitomate<CVerduleria>(3);   
            Console.WriteLine("Donde le gustaria comprar su jitomate?1. Campo, 2.Camion, 3.Central de abastos, 4. En verduleria");
            leer = Console.ReadLine();

            switch (leer)
            {
                case "1":
                   
                    ventas.agregar(new CCampo(100));
                    ventas.agregar(new CCampo(120));
                    ventas.agregar(new CCampo(125));
                    break;
           
                case "2":
                    ventas2.agregar(new CCamion(130));
                    ventas2.agregar(new CCamion(135));
                    ventas2.agregar(new CCamion(130));
                    break;
           
                case"3":
                    ventas3.agregar(new CCentralDeAbastos(180));
                    ventas3.agregar(new CCentralDeAbastos(190));
                    ventas3.agregar(new CCentralDeAbastos(200));
                    break;
                case"4":
                    ventas4.agregar(new CVerduleria(300));
                    ventas4.agregar(new CVerduleria(310));
                    ventas4.agregar(new CVerduleria(350));
                    break;
            }
            


        }
    }
}
