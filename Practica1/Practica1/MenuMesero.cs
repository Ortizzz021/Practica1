using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

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
            Console.WriteLine($"Bienvenido al Menú del Mesero, {Mesero.Nombre}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1. Registrar nuevo pedido");
            Console.WriteLine("2. Liquidar factura");
            Console.WriteLine("3. Salir");

            // Leer la opción seleccionada por el mesero
            string opcion = Console.ReadLine();

            // Procesar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    registrar_pedido();
                    break;
                case "2":
                    Console.WriteLine("Seleccione la mesa para liquidar la factura:");
                    for (int i = 0; i < Mesas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Mesa {Mesas[i].Numero}");
                    }

                    // Leer la opción seleccionada por el usuario
                    int seleccion = int.Parse(Console.ReadLine());
                    if (seleccion < 1 || seleccion > Mesas.Count)
                    {
                        Console.WriteLine("Selección no válida.");
                        break;
                    }

                    Mesa mesa_a_facturar = Mesas[seleccion - 1];
                    liquidar_factura(mesa_a_facturar);
                    break;
                case "3":
                    Console.WriteLine("Saliendo del menú del mesero...");
                    // Implementa la lógica para salir del menú
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    opciones_mesero(); // Vuelve a mostrar el menú en caso de opción no válida
                    break;
            }
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