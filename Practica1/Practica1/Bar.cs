using System.Text.RegularExpressions;

namespace Practica1.Pratica1
{
    public class Bar
    {
        private List<Mesa> Mesas { get; set; }
        private List<Mesero> Meseros { get; set; }
        private List<Pedido> Pedidos { get; set; }

        public Bar(List<Mesa> mesas, List<Mesero> meseros, List<Pedido> pedidos)
        {
            Mesas = mesas;
            Meseros = meseros;
            Pedidos = pedidos;
        }


        public void elegir_usuario()
        {
            int opcion = 0;
            Console.WriteLine("Bienvenido a la Aplicación de Gestión del Bar");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esta aplicacion para el administrador y los meseros les permitira hacer la gestion del bar de una manera eficiente.");
            Console.WriteLine("Los meseros podrán registrar los pedidos y liquidar las facturas para que las mesas paguen.");
            Console.WriteLine("Y por otro lado los administradores podran analizar el trabajo de los meseros y ver que esta pasando en cada mesa");
            Console.WriteLine();
            while (opcion != 3)
            {
                Console.WriteLine("¿Qué menú desea usar?");
                Console.WriteLine("1. Menú del Mesero");
                Console.WriteLine("2. Menú del Administrador");
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
                    mostrar_meseros();
                    Console.WriteLine("Ingrese el ID del mesero que esta usando la aplicación:");
                    string mesero_id = Console.ReadLine();
                    Console.WriteLine();
                    bool es_valido = validar_id(mesero_id);
                    if (es_valido == true)
                    {
                        Mesero mesero = Meseros.Find(m => m.Id.Equals(mesero_id, StringComparison.OrdinalIgnoreCase));
                        if (mesero != null)
                        {
                            MenuMesero menu_mesero = new MenuMesero(mesero, Mesas, Pedidos);
                            menu_mesero.opciones_mesero();
                        }
                        else
                        {
                            Console.WriteLine("ID de mesero no encontrado.");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("El ID del mesero no es valido");
                        Console.WriteLine();
                    }
                    
                }
                else if (opcion == 2)
                {
                    MenuAdministrador menu_administrador = new MenuAdministrador(Mesas, Meseros, Pedidos);
                    menu_administrador.opciones_administrador();
                }
                else if (opcion > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                }
            }
            Console.WriteLine("---------------------------------------------");
        }

        private void mostrar_meseros()
        {
            Console.WriteLine("Lista de Meseros:");
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"{mesero.Id} - {mesero.Nombre}");
            }
            Console.WriteLine();
        }

        static bool validar_id(string id)
        {
            string patron = @"^MS\d+$";
            return Regex.IsMatch(id, patron);
        }
    }
}