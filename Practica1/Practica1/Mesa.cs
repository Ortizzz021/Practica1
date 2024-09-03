namespace Practica1.Pratica1
{
    public class Mesa
    {
        public string Numero { get; set; }
        public Factura Factura { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Mesa(string numero)
        {
            Numero = numero;
            Pedidos = new List<Pedido>();
        }

        public float calcular_gastos_activos()
        {
            float gastos = 0;
            foreach (var pedido in Pedidos)
            {
                gastos += pedido.Total;
            }
            return gastos;
        }
    }
}