using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1.Pratica1
{
    public class Restaurante
    {
        private List<Mesa> Mesas { get; set; }
        private List<Mesero> Meseros { get; set; }
        private List<Pedido> Pedidos { get; set; }

        public Restaurante(List<Mesa> mesas, List<Mesero> meseros, List<Pedido> pedidos)
        {
            Mesas = mesas;
            Meseros = meseros;
            Pedidos = pedidos;
        }


        public void elegir_usuario()
        {
            // Mostrar mensaje de bienvenida
            Console.WriteLine("Bienvenido a la Aplicación de Gestión del Bar");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esta aplicacion para el administrador y los meseros les permitira hacer la gestion del bar de una manera eficiente.");
            Console.WriteLine("Los meseros podrán registrar los pedidos y liquidar las facturas para que las mesas paguen.");
            Console.WriteLine("Y por otro lado los administradores podran analizar el trabajo de los meseros y ver que esta pasando en cada mesa");
            Console.WriteLine();

            // Mostrar opciones de menú
            Console.WriteLine("¿Qué menú desea usar?");
            Console.WriteLine("1. Menú del Mesero");
            Console.WriteLine("2. Menú del Administrador");

            // Leer la opción seleccionada por el usuario
            string opcion = Console.ReadLine();

            // Procesar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    MostrarMeseros();
                    Console.WriteLine("Ingrese el ID del mesero que esta usando la aplicación:");
                    string mesero_id = Console.ReadLine();
                    Mesero mesero = Meseros.Find(m => m.Id.Equals(mesero_id, StringComparison.OrdinalIgnoreCase));

                    if (mesero != null)
                    {
                        MenuMesero menu_mesero = new MenuMesero(mesero, Mesas, Pedidos);
                        menu_mesero.opciones_mesero();
                    }
                    else
                    {
                        Console.WriteLine("ID de mesero no encontrado.");
                    }
                    break;
                case "2":
                    MenuAdministrador menu_administrador = new MenuAdministrador(Mesas, Meseros, Pedidos);
                    menu_administrador.opciones_administrador();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }

        private void MostrarMeseros()
        {
            Console.WriteLine("Lista de Meseros:");
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"{mesero.Id} - {mesero.Nombre}");
            }
        }
    }
}