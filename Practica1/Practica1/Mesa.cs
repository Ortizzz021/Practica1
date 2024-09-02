﻿using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Mesa
    {
        public string Numero { get; set; }
        public Factura Factura { get; set; }
        public List<Pedido> Pedidos { get; set; }

        public Mesa(string numero)
        {
            Numero = numero;
            Factura = new Factura();
            Pedidos = new List<Pedido>();
        }

        public void pagar_factura(Factura factura)
        {

        }

        public float calcular_gastos_activos()
        {
            float gastos = 0;
            foreach (var pedido in Pedidos)
            {
                gastos += pedido.Total;
            }
            return gastos;
        }
    }
}