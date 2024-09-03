using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

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

        public void registrar_pedido(List<Pedido> pedidos, List<Mesa> mesas)
        {
            Random random = new Random();
            Pedido pedido_aleatorio = pedidos[random.Next(pedidos.Count)];
            Mesa mesa_aleatoria = mesas[random.Next(mesas.Count)];

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
            Factura factura = new Factura(mesa_a_facturar.Numero, total_factura, calcular_propina(total_factura));
            mesa_a_facturar.Factura = factura;
            Console.WriteLine($"La factura fue liquidada correctamente a la mesa {mesa_a_facturar.Numero}.");
        }

        public float calcular_propina(float total_factura)
        {
            float propina = (float)(total_factura * 0.08);
            Propinas += propina;
            return propina;
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