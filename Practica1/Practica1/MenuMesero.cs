using Practica1.Practica1;

namespace Practica1.Pratica1
{
    public class MenuMesero
    { 
        public Mesero Mesero { get; set; }
        public Bar Bar { get; set; }

        public MenuMesero(Mesero mesero, Bar bar)
        {
            Mesero = mesero;
            Bar = bar;
        }

        public void opciones_mesero()
        {
            var opcion = 0;
            while (opcion != 3)
            {
                opcion = Opciones.opciones_mesero();
                if (opcion <= 0)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
                if (opcion == 1)
                {
                    Bar.agregar_pedido(Mesero.registrar_pedido(Bar.Pedidos, Bar.Mesas));
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Seleccione la mesa para liquidar la factura:");
                    for (int i = 0; i < Bar.Mesas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Mesa {Bar.Mesas[i].Numero}");
                    }
                    int seleccion = int.Parse(Console.ReadLine());
                    if (seleccion < 1 || seleccion > Bar.Mesas.Count)
                    {
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    }
                    else
                    {
                        Mesa mesa_a_facturar = Bar.Mesas[seleccion - 1];
                        Pedido.liquidar_factura(Mesero, mesa_a_facturar);
                    }
                }
                else if (opcion > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
            }
            return;
        }
    }
}