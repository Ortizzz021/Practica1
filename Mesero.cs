using System;
using Practica1;

namespace Practica1
{
    public class Mesero
    {
        private string id;
        private string nombre;
        private list<Pedido> pedidos;
        private float propinas = 0;

        public Mesero(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            pedidos = new list<Pedido>
        }

        public void registrar_pedido(Pedido pedido, Mesa mesa)
        {
            pedidos.Add(pedido);
            mesa.agregar_pedido(pedido);
        }

        public Factura liquidar_factura(Pedido pedido_a_facturar)
        {
            foreach(var pedido in pedidos)
            {
                if(pedido.id == pedido_a_facturar.id)
                {
                    factura = new Factura(id, pedido_a_facturar, calcular_propina(pedido_a_facturar))
                }
            }
            return factura;
        }

        public float calcular_propina(Pedido pedido)
        {
            total = pedido.calcular_total();
            propina = total * 0.08
            return propina;
        }

        public int mesas_atendidas()
        {
            mesas = 0;
            for(int i = 0; i < pedidos.Count, i++)
            {
                mesas += 1;
            }
            return mesas;
        }
    }
}