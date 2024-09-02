using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Mesero
    {
        private string Id { get; set; }
        private string Nombre { get; set; }
        private List<Pedido> Pedidos { get; set; }
        private float Propinas { get; set; }

        public Mesero(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Pedidos = new List<Pedido>;
            Propinas = 0;
        }

        public void registrar_pedido(list<Pedido> pedidos, list<Mesa> mesas)
        {
            Random random = Random();
            Pedido pedido_aleatorio = pedidos[random.Next(Pedidos.Count)];
            Mesa mesa_aleatoria = mesas[random.Next(Mesas.Count)];

            mesa_aleatoria.Pedidos.Add(pedido_aleatorio);
            Pedidos.Add(pedido_aleatorio);

            Console.WriteLine($"El pedido {pedido_aleatorio.Id} fue registrado exitosamente a la mesa {mesa_aleatoria.Numero}.");
        }

        public void liquidar_factura(Mesa mesa_a_facturar)
        {
            float total_factura = 0;
            foreach (var pedido in mesa_a_facturar.Pedidos)
            {
                total_factura += pedido.Total;
            }
            Factura factura = new Factura(mesa_a_facturar.Id, total_factura, calcular_propina(total_factura);
            mesa_a_facturar.Factura = factura;
            Console.WriteLine($"La factura fue liquidada correctamente a la mesa {mesa_a_facturar.Numero}.");
        }

        public float calcular_propina(float total_factura)
        {
            float propina = total_factura * 0.08
            Propinas += propina
            return propina;
        }

        public int mesas_atendidas()
        {
            int mesas = 0;
            for(int i = 0; i < Pedidos.Count, i++)
            {
                mesas += 1;
            }
            return mesas;
        }
    }
}