using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
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
    }
}