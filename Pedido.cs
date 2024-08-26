using System;
using Practica1;

namespace Practica1
{
    public class Pedido
    {
        private string id;
        private Mesa mesa;
        private list<Producto> productos;
        private list<int> cantidades;
        private float total = 0;

        public Pedido(string id, Mesa mesa, list<Producto> productos, list<int> cantidad)
        {
            this.id = id;
            this.mesa = mesa;
            this.productos = productos;

            this.cantidad = cantidad;
        }
        public float calcular_total()
        {
            if (productos.Count == cantidad.Count)
            {
                total = 0;
                for (int i = 0; i < productos.Count; i++)
                {
                    producto = productos[i];
                    total += producto.precio * cantidades[i];
                }
            }
            this.total = total;
            return total;
        }
    }
}