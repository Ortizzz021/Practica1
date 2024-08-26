using System;
using Practica1;

namespace Practica1
{
    public class Mesa
    {
        private string numero;
        private Factura factura;
        private list<Pedido> pedidos;

        public Mesa(string numero, Factura factura)
        {
            this.numero = numero;
            this.factura = factura;
            pedidos = new list<Pedido>;
        }

        public void agregar_pedido(Pedido pedido)
        {
            pedidos.add(pedido);
        }

        public void pagar_factura(Factura factura)
        {

        }

        public float calcular_gastos_activos()
        {
            gastos = 0;
            foreach(var pedido in pedidos)
            {
                gastos += pedido.calcular_total()
            }
            return gastos;
        }
}