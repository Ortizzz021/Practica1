namespace Practica1.Pratica1
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