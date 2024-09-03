namespace Practica1.Pratica1
{
    public class Administrador
    {
        private List<Mesero> Meseros { get; set; }
        private List<Mesa> Mesas { get; set; }

        public Administrador(List<Mesero> meseros, List<Mesa> mesas)
        {
            Meseros = meseros;
            Mesas = mesas;
        }

        public void visualizar_mesas_atendidas()
        {
            
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"La cantidad de mesas que atendio {mesero.Nombre} fueron {mesero.mesas_atendidas()}");
            }
        }

        public void visualizar_propinas()
        {
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"El total de propinas que tiene {mesero.Nombre} es de {mesero.Propinas}");
            }
        }

        public void evaluar_efectividad()
        {
            foreach (var mesero in Meseros)
            {
                float efectividad = 0;
                efectividad = mesero.Propinas / mesero.mesas_atendidas();
                Console.WriteLine($"La efectividad que tiene el mesero {mesero.Nombre} es de {efectividad}");
            }
        }

        public void visualizar_mesas()
        {
            Console.WriteLine("Mesas y Gastos Activos:");
            Console.WriteLine("-----------------------");

            int mesas_por_fila = 3;
            int contador = 0;

            for (int i = 0; i < Mesas.Count / mesas_por_fila; i++)
            {
                for (int j = 0; j < mesas_por_fila; j++)
                {
                    if (contador < Mesas.Count)
                    {
                        Mesa mesa = Mesas[contador];
                        float gastos_activos = mesa.calcular_gastos_activos();
                        Console.Write($"[Mesa {mesa.Numero}: ${gastos_activos}]\t");

                        contador++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}