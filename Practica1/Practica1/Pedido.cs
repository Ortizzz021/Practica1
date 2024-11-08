namespace Practica1.Pratica1
{
    public class Pedido
    {
        public string Id { get; set; }
        private List<Producto> Productos { get; set; }
        private List<int> Cantidades { get; set; }
        public float Total { get; set; }

        public Pedido(string id, List<Producto> productos, List<int> cantidad, float total)
        {
            Id = id;
            Productos = productos;
            Cantidades = cantidad;
            Total = total;
        }

        public static void liquidar_factura(Mesero mesero, Mesa mesa_a_facturar)
        {

            if (mesa_a_facturar.Pedidos.Count > 0)
            {
                float total_factura = 0;
                foreach (var pedido in mesa_a_facturar.Pedidos)
                {
                    total_factura += pedido.Total;
                }

                float propina = (float)(total_factura * 0.08);
                mesero.Propinas += propina;

                Factura factura = new Factura(mesa_a_facturar.Numero, total_factura, propina);
                mesa_a_facturar.Factura = factura;
                Console.WriteLine($"La factura fue liquidada correctamente a la mesa {mesa_a_facturar.Numero}.");
                mesa_a_facturar.Pedidos.Clear();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("La mesa no tiene pedidos todavia, no se puede liquidar la factura.");
                Console.WriteLine();
            }
        }
    }
}