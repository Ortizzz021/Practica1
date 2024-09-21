using Practica1.Practica1;

namespace Practica1.Pratica1
{
    public class MenuAdministrador
    {
        private List<Mesa> Mesas { get; set; }
        private List<Mesero> Meseros { get; set; }
        private List<Pedido> Pedidos { get; set; }
        private Administrador Administrador { get; set; }

        public MenuAdministrador(List<Mesa> mesas, List<Mesero> meseros, List<Pedido> pedidos)
        {
            Mesas = mesas;
            Meseros = meseros;
            Pedidos = pedidos;
            Administrador = new Administrador(Meseros, Mesas);
        }

        public void opciones_administrador()
        {
            int opcion = 0;
            Console.WriteLine("Bienvenido al Menú del Administrador");
            Console.WriteLine("------------------------------------");
            while (opcion != 5)
            {
                Console.WriteLine("1. Ver cuantas mesas han atendido los meseros");
                Console.WriteLine("2. Ver el total de las propinas de los meseros");
                Console.WriteLine("3. Evaluar la efectividad de los meseros");
                Console.WriteLine("4. Ver todas las mesas y sus gastos activos");
                Console.WriteLine("5. Salir al menú principal");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcion <= 0)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
                if (opcion == 1)
                {
                    visualizar_mesas_atendidas();
                }
                else if (opcion == 2)
                {
                    visualizar_propinas();
                }
                else if (opcion == 3)
                {
                    evaluar_efectividad();
                }
                else if (opcion == 4)
                {
                    visualizar_mesas();
                }
                else if (opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("------------------------------------");
        }

        public void visualizar_mesas_atendidas()
        {
            Administrador.visualizar_mesas_atendidas();
        }

        public void visualizar_propinas()
        {
            Administrador.visualizar_propinas();
        }

        public void evaluar_efectividad()
        {
            Administrador.evaluar_efectividad();
        }

        public void visualizar_mesas()
        {
            Administrador.visualizar_mesas();
        }
    }
}
