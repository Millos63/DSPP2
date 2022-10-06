using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcialAutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables globales para el uso del programa
            string leer = "";
            int opc = 0;

            Console.WriteLine("BEST-CAR");
            Console.WriteLine("Bienvenido a BEST-CAR la aplicación que te ayudara a elegir un auto según tus necesidades");

            while (opc!=7)
            {
                
                Console.WriteLine("\r\nQué categoria de auto le gustaria ver? 1.Deportivos, 2.Clasicos, 3.Familiares, 4.Sedanes, 5.Enlistar todos, 6.Ver avion, 7. Salir");
                leer = Console.ReadLine();
                opc = Convert.ToInt32(leer);

                //Instanciamos las clases
                CDeportivo miDeportivo = new CDeportivo("Lamborgini Huracan");
                CClasico miClasico = new CClasico("Ford Mustang 68");
                CFamiliar miFamiliar = new CFamiliar("Mercedes Sprinter");
                CSedan miSedan = new CSedan("Subaru Impreza");

                //Arreglo para crear las instancias de las clases
                CAuto[] arregloCoches = new CAuto[4];
                arregloCoches[0] = miDeportivo;
                arregloCoches[1] = miClasico;
                arregloCoches[2] = miFamiliar;
                arregloCoches[3] = miSedan;

                if (opc == 1)
                {
                    arregloCoches[0].caracteristicas();
                    arregloCoches[0].getNombre();
                    arregloCoches[0].motor();
                    arregloCoches[0].neumaticos();
                    miDeportivo.frenadoABS();
                    Console.WriteLine("Caballos de fuerza: " + miDeportivo.CaballosDeFuerza());
                    Console.WriteLine("KM/H: " + miDeportivo.KilometrosPorHora());
                    Console.WriteLine("Transmisión: " + miDeportivo.Transmision());
                    if(miDeportivo.EsTiptronic() == true)
                        Console.WriteLine("El auto cuenta con caja Tiptronic");
                    else
                        Console.WriteLine("El auto no cuenta con caja Tipronic");
                        
                    
                }

                if (opc == 2)
                {
                    arregloCoches[1].caracteristicas();
                    arregloCoches[1].getNombre();
                    arregloCoches[1].motor();
                    arregloCoches[1].neumaticos();
                    miClasico.mecanicaFacil();
                    Console.WriteLine("Caballos de fuerza: " + miClasico.CaballosDeFuerza());
                    Console.WriteLine("KM/H: " + miClasico.KilometrosPorHora());
                    Console.WriteLine("Transmisión: " + miClasico.Transmision());
                    if (miClasico.EsTiptronic() == true)
                        Console.WriteLine("El auto cuenta con caja Tiptronic");
                    else
                        Console.WriteLine("El auto no cuenta con caja Tipronic");
                }

                if (opc == 3)
                {
                    arregloCoches[2].caracteristicas();
                    arregloCoches[2].getNombre();
                    arregloCoches[2].motor();
                    arregloCoches[2].neumaticos();
                    miFamiliar.espacio();
                    Console.WriteLine("Caballos de fuerza: " + miFamiliar.CaballosDeFuerza());
                    Console.WriteLine("KM/H: " + miFamiliar.KilometrosPorHora());
                    Console.WriteLine("Transmisión: " + miFamiliar.Transmision());
                    if (miFamiliar.EsTiptronic() == true)
                        Console.WriteLine("El auto cuenta con caja Tiptronic");
                    else
                        Console.WriteLine("El auto no cuenta con caja Tipronic");
                }

                if (opc == 4)
                {
                    arregloCoches[3].caracteristicas();
                    arregloCoches[3].getNombre();
                    arregloCoches[3].motor();
                    arregloCoches[3].neumaticos();
                    miSedan.estable();
                    Console.WriteLine("Caballos de fuerza: " + miSedan.CaballosDeFuerza());
                    Console.WriteLine("KM/H: " + miSedan.KilometrosPorHora());
                    Console.WriteLine("Transmisión: " + miSedan.Transmision());
                    if (miSedan.EsTiptronic() == true)
                        Console.WriteLine("El auto cuenta con caja Tiptronic");
                    else
                        Console.WriteLine("El auto no cuenta con caja Tipronic");
                }
                if (opc == 5)
                {
                    for (int i = 0; i < arregloCoches.Length; i++)
                    {
                        arregloCoches[i].caracteristicas();
                        arregloCoches[i].getNombre();
                        arregloCoches[i].motor();
                        arregloCoches[i].neumaticos();
                        Console.WriteLine("\n\r");
                    }
                }

                if (opc == 6)
                {
                    CAvion miAvion = new CAvion("Boeing 747");
                    miAvion.getNombre();
                    miAvion.motor();
                }

            }
            
            
            


        }
    }
}
