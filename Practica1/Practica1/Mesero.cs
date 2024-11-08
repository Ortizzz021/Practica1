namespace Practica1.Pratica1
{
    public class Mesero
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public float Propinas { get; set; }

        public Mesero(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Pedidos = new List<Pedido>();
            Propinas = 0;
        }

        public Pedido registrar_pedido(List<Pedido> pedidos, List<Mesa> mesas)
        {
            Random random = new Random();
            Pedido pedido_aleatorio = pedidos[random.Next(pedidos.Count)];
            Mesa mesa_aleatoria = mesas[random.Next(mesas.Count)];

            mesa_aleatoria.Pedidos.Add(pedido_aleatorio);
            Pedidos.Add(pedido_aleatorio);

            Console.WriteLine($"El pedido {pedido_aleatorio.Id} fue registrado exitosamente a la mesa {mesa_aleatoria.Numero}.");
            Console.WriteLine();

            return pedido_aleatorio;
        }
        public int mesas_atendidas()
        {
            int mesas = 0;
            for(int i = 0; i < Pedidos.Count; i++)
            {
                mesas += 1;
            }
            return mesas;
        }
    }
}