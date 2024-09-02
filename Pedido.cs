using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Pedido
    {
        private string Id { get; set; }
        private list<Producto> Productos { get; set; }
        private list<int> Cantidades { get; set; }
        private float Total { get; set; }

        public Pedido(string id, list<Producto> productos, list<int> cantidad, float total)
        {
            Id = id;
            Productos = productos;
            Cantidad = cantidad;
            Total = total;
        }
    }
}