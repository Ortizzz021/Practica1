using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1.Pratica1
{
    public class Factura
    {
        private string Id { get; set; }
        private float Total { get; set; }
        private float Propina { get; set; }
        private float TotalConPropina { get; set; }

        public Factura(string id, float total, float propina)
        {
            Id = id;
            Total = total;
            Propina = propina;
            TotalConPropina = Total + Propina;
        }
    }
}