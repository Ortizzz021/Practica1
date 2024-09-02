using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Producto
    {
        private string Nombre { get; set; }
        private float Precio { get; set; }

        public Producto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}