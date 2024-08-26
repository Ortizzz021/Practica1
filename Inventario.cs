using System;
using Practica1;

namespace Practica1
{
    public class Inventario
    {
        private list<Producto> productos;
        private list<int> cantidad;

        public Inventario()
        {
            productos = new list<Producto>
            cantidad = new list<int>
        }
    }

        public void agregar_trago(string id, string nombre, float precio)
        {
            Producto trago = new Trago(id, nombre, precio);
            productos.add(trago);
        }

        public void agregar_comida(string id, string nombre, float precio)
        {
            Producto comida = new Comida(id, nombre, precio);
            productos.add(comida);
        }
    }
}