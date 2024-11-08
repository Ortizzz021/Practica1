using Practica1.Practica1;

namespace Practica1.Pratica1
{
    public class MenuAdministrador
    {
        public Administrador Administrador { get; set; }
        public Bar Bar { get; set; }

        public MenuAdministrador(Bar bar)
        {
            Bar = bar;
            Administrador = new Administrador(Bar);
        }

        public void opciones_administrador()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                opcion = Opciones.opciones_administrador();
                if (opcion <= 0)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
                if (opcion == 1)
                {
                    Administrador.visualizar_mesas_atendidas();
                }
                else if (opcion == 2)
                {
                    Administrador.visualizar_propinas();
                }
                else if (opcion == 3)
                {
                    Administrador.evaluar_efectividad();
                }
                else if (opcion == 4)
                {
                    Administrador.visualizar_mesas();
                }
                else if (opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("------------------------------------");
            return;
        }
    }
}
