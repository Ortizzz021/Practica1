using System;
using System.Collections.Generic;
using System.IO;
using Practica1;
using Practica1.Practica1;

namespace Practica1.Pratica1
{
    public class MenuMesero
    { 
        public Mesero Mesero { get; set; }
        public List<Mesa> Mesas { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public MenuMesero(Mesero mesero, List<Mesa> mesas, List<Pedido> pedidos)
        {
            Mesero = mesero;
            Mesas = mesas;
            Pedidos = pedidos;
        }

        public void opciones_mesero()
        {
            int opcion = 0;
            Console.WriteLine($"Bienvenido al Menú del Mesero, {Mesero.Nombre}");
            Console.WriteLine("----------------------------------------------------");
            while(opcion != 3)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Registrar nuevo pedido");
                Console.WriteLine("2. Liquidar factura");
                Console.WriteLine("3. Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcion <= 0)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
                if (opcion == 1)
                {
                    registrar_pedido();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Seleccione la mesa para liquidar la factura:");
                    for (int i = 0; i < Mesas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Mesa {Mesas[i].Numero}");
                    }
                    int seleccion = int.Parse(Console.ReadLine());
                    if (seleccion < 1 || seleccion > Mesas.Count)
                    {
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    }
                    else
                    {
                        Mesa mesa_a_facturar = Mesas[seleccion - 1];
                        liquidar_factura(mesa_a_facturar);
                    }
                    
                }
                else if (opcion > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("----------------------------------------------------");
        }

        public void registrar_pedido()
        {
            Mesero.registrar_pedido(Pedidos, Mesas);
        }

        public void liquidar_factura(Mesa mesa_a_facturar)
        {
            Mesero.liquidar_factura(mesa_a_facturar);
        }
    }
}