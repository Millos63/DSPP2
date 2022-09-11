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

            while (opc!=6)
            {
                
                Console.WriteLine("\r\nQué categoria de auto le gustaria ver? 1.Deportivos, 2.Clasicos, 3.Familiares, 4.Sedanes, 5.Enlistar todos, 6.Salir");
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
                    
                }

                if (opc == 2)
                {
                    arregloCoches[1].caracteristicas();
                    arregloCoches[1].getNombre();
                    arregloCoches[1].motor();
                    arregloCoches[1].neumaticos();
                    miClasico.mecanicaFacil();
                }

                if (opc == 3)
                {
                    arregloCoches[2].caracteristicas();
                    arregloCoches[2].getNombre();
                    arregloCoches[2].motor();
                    arregloCoches[2].neumaticos();
                    miFamiliar.espacio();
                }

                if (opc == 4)
                {
                    arregloCoches[3].caracteristicas();
                    arregloCoches[3].getNombre();
                    arregloCoches[3].motor();
                    arregloCoches[3].neumaticos();
                    miSedan.estable();
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

            }
            
            
            


        }
    }
}
