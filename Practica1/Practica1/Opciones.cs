
namespace Practica1.Practica1
{
    public class Opciones
    {
        public static int elegir_usuario()
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
                    return opcion;
                }
                if (opcion == 1)
                {
                    return opcion;
                }
                else if (opcion == 2)
                {
                    return opcion;
                }
                else if (opcion > 3)
                {
                    return opcion;
                }
            }
            Console.WriteLine("---------------------------------------------");
            return opcion;
        }

        public static int opciones_mesero()
        {
            int opcion = 0;
            Console.WriteLine($"Bienvenido al Menú del Mesero");
            Console.WriteLine("----------------------------------------------------");
            while (opcion != 3)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1. Registrar nuevo pedido");
                Console.WriteLine("2. Liquidar factura");
                Console.WriteLine("3. Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcion <= 0)
                {
                    return opcion;
                }
                if (opcion == 1)
                {
                    return opcion;
                }
                else if (opcion == 2)
                {
                    return opcion;
                }
                else if (opcion > 3)
                {
                    return opcion;
                }

            }
            Console.WriteLine("----------------------------------------------------");
            return opcion;
        }

        public static int opciones_administrador()
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
                    return opcion;
                }
                if (opcion == 1)
                {
                    return opcion;
                }
                else if (opcion == 2)
                {
                    return opcion;
                }
                else if (opcion == 3)
                {
                    return opcion;
                }
                else if (opcion == 4)
                {
                    return opcion;
                }
                else if (opcion > 5)
                {
                    return opcion;
                }
            }
            Console.WriteLine("------------------------------------");
            return opcion;
        }
    }
}
