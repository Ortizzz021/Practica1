namespace Practica1.Pratica1
{
    public class Administrador
    {
        public Bar Bar { get; set; }

        public Administrador(Bar bar)
        {
            Bar = bar;
        }

        public void visualizar_mesas_atendidas()
        {
            
            foreach (var mesero in Bar.Meseros)
            {
                Console.WriteLine($"La cantidad de mesas que atendio {mesero.Nombre} fueron {mesero.mesas_atendidas()}");
            }
            Console.WriteLine();
        }

        public void visualizar_propinas()
        {
            foreach (var mesero in Bar.Meseros)
            {
                Console.WriteLine($"El total de propinas que tiene {mesero.Nombre} es de {mesero.Propinas}");
            }
            Console.WriteLine();
        }

        public void evaluar_efectividad()
        {
            foreach (var mesero in Bar.Meseros)
            {
                float efectividad = 0;
                efectividad = mesero.Propinas / mesero.mesas_atendidas();
                Console.WriteLine($"La efectividad que tiene el mesero {mesero.Nombre} es de {efectividad}");
            }
            Console.WriteLine();
        }

        public void visualizar_mesas()
        {
            Console.WriteLine("Mesas y Gastos Activos:");
            Console.WriteLine("-----------------------");

            int mesas_por_fila = 3;
            int contador = 0;

            for (int i = 0; i < Bar.Mesas.Count / mesas_por_fila; i++)
            {
                for (int j = 0; j < mesas_por_fila; j++)
                {
                    if (contador < Bar.Mesas.Count)
                    {
                        Mesa mesa = Bar.Mesas[contador];
                        float gastos_activos = mesa.calcular_gastos_activos();
                        Console.Write($"[Mesa {mesa.Numero}: ${gastos_activos}]\t");

                        contador++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}