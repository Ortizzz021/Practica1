using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Administrador
    {
        private List<Mesero> Meseros { get; set; }
        private List<Mesa> Mesas { get; set; }

        public Administrador(List<Mesero> meseros, List<Mesa> mesas)
        {
            Meseros = meseros;
            Mesas = mesas;
        }

        public void visualizar_mesas_atendidas()
        {
            
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"La cantidad de mesas que atendio {mesero.Nombre} fueron {mesero.mesas_atendidas()}");
            }
        }

        public void visualizar_propinas()
        {
            foreach (var mesero in Meseros)
            {
                Console.WriteLine($"El total de propinas que tiene {mesero.Nombre} es de {mesero.Propinas}");
            }
        }

        public void evaluar_efectividad()
        {
            foreach (var mesero in Meseros)
            {
                float efectividad = 0;
                efectividad = mesero.Propinas / mesero.mesas_atendidas();
                Console.WriteLine($"La efectividad que tiene el mesero {mesero.Nombre} es de {efectividad}");
            }
        }

        public void visualizar_mesas()
        {
            Console.WriteLine("Mesas y Gastos Activos:");
            Console.WriteLine("-----------------------");

            int mesas_por_fila = 3; // Cantidad de mesas por fila
            int contador = 0; // Contador para recorrer las mesas

            // Recorremos todas las mesas en grupos para formar la matriz
            for (int i = 0; i < Mesas.Count / mesas_por_fila; i++)
            {
                // Recorremos cada fila
                for (int j = 0; j < mesas_por_fila; j++)
                {
                    // Si aún hay mesas, las mostramos
                    if (contador < Mesas.Count)
                    {
                        Mesa mesa = Mesas[contador];
                        float gastos_activos = mesa.calcular_gastos_activos();

                        // Mostramos el número de mesa y sus gastos activos en formato de celda
                        Console.Write($"[Mesa {mesa.Numero}: ${gastos_activos}]\t");

                        contador++;
                    }
                }
                Console.WriteLine(); // Salto de línea para pasar a la siguiente fila
            }
        }
    }
}