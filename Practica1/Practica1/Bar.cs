using Practica1.Practica1;
using System.Text.RegularExpressions;

namespace Practica1.Pratica1
{
    public class Bar
    {
        public List<Mesa> Mesas { get; set; }
        public List<Mesero> Meseros { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Bar(List<Mesa> mesas, List<Mesero> meseros, List<Pedido> pedidos)
        {
            Mesas = mesas;
            Meseros = meseros;
            Pedidos = pedidos;
        }

        public void elegir_usuario()
        {
            int opcion = 0;
            while(opcion != 3)
            {
                opcion = Opciones.elegir_usuario();
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
                            MenuMesero menu_mesero = new MenuMesero(mesero, this);
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
                    MenuAdministrador menu_administrador = new MenuAdministrador(this);
                    menu_administrador.opciones_administrador();
                }
                else if (opcion > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                }
            }
            return;
        }

        public void agregar_pedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
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

        private bool validar_id(string id)
        {
            string patron = @"^MS\d+$";
            return Regex.IsMatch(id, patron);
        }
    }
}