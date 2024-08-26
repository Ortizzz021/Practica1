using System;
using Practica1;

namespace Practica1
{
    public class Restaurante
    {
        private list<Mesero> meseros;
        private list<Mesa> mesas;
        private Inventario inventario;

        public Restaurante()
        {
            meseros = new list<Mesero>
            mesas = new list<Mesa>
            inventario = new Inventario()
        }

        public void agregar_mesero(string id, string nombre)
        {
            Mesero mesero = new Mesero(id, nombre);
            meseros.Add(mesero);
        }

        public void agregar_mesa(string numero)
        {
            Mesa mesa = new Mesa(id, nombre);
            meseros.Add(mesa);
        }

        public void agregar_trago(string id, string nombre, float precio)
        {
            inventario.agregar_trago(id, nombre, precio);
        }

        public void agregar_comida(string id, string nombre, float precio)
        {
            inventario.agregar_comida(id, nombre, precio);
        }

        public void elegir_usuario(int opcion)
        {

        }
    }
}
