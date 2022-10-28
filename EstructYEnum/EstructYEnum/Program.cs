using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructYEnum
{
    enum contenedor { taraG = 20, taraM = 10, carton = 15, domo = 18 };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables para trabajar
            string leer = "";
            double precioJitomate = 0;
            int opc = 0;
            while (leer != "3")
            {
                Console.WriteLine("Bienvenido a el programa de venta de jitomate Rojos \n" +
                "Elija una opcion: \n" +
                "1. Vender Jitomate \n" +
                "2. Ver camion de carga \n" +
                "3. Salir");
                leer = Console.ReadLine();

                if(leer == "1")
                {

                    contenedor vent1 = contenedor.taraG;
                    contenedor vent2 = contenedor.taraM;
                    contenedor vent3 = contenedor.carton;
                    contenedor vent4 = contenedor.domo;

                    //Casting el tipo de variable que queremos usar, el nombre = a el tipo de dato y nombre de la variable.
                    double contVenta1 = (double)vent1;
                    double contVenta2 = (double)vent2;
                    double contVenta3 = (double)vent3;
                    double contVenta4 = (double)vent4;

                    Console.WriteLine("En cuanto esta el precio del jitomate?");
                    leer = Console.ReadLine();
                    precioJitomate = Convert.ToDouble(leer);
                    Console.WriteLine("En que contenedor se vendera el producto?\n" +
                        "1. Tara Grande 20\n" +
                        "2. Tara Mediana 10\n" +
                        "3. Caja de carton 15\n" +
                        "4. Domo de plastico 18\n");
                    leer = Console.ReadLine();
                    opc = Convert.ToInt32(leer);

                    if(opc == 1)
                    {
                        CVentaJitomate venta = new CVentaJitomate(vent1, precioJitomate);
                        System.Console.WriteLine("Precio Total:" + venta.getPrecioTotal());
                    }
                    else if (opc == 2)
                    {
                        CVentaJitomate venta = new CVentaJitomate(vent2, precioJitomate);
                        System.Console.WriteLine("Precio Total:" + venta.getPrecioTotal());
                    }
                    else if (opc == 3)
                    {
                        CVentaJitomate venta = new CVentaJitomate(vent3, precioJitomate);
                        System.Console.WriteLine("Precio Total:" + venta.getPrecioTotal());
                    }
                    else if (opc == 4)
                    {
                        CVentaJitomate venta = new CVentaJitomate(vent4, precioJitomate);
                        System.Console.WriteLine("Precio Total:" + venta.getPrecioTotal());
                    }

                    leer = "0";   
                }

                if(leer == "2")
                {
                    CCamion camion1 = new CCamion(1200, 80);
                    Console.WriteLine(camion1);

                    camion1.CambiarCupo(camion1, 300);
                    Console.WriteLine(camion1);
                    
                }

            }


        }
    }
}
