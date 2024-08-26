using System;
using Practica1;

namespace Practica1
{
    public class Producto
    {
        private string id;
        private string nombre;
        private float precio;

        public Producto(string id, string nombre, float precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        public float obtener_precio()
        {

        }
    }

    public class Trago : Producto
    {

    }

    public class Comida : Producto
    {

    }
}