using System;
using System.Collections.Generic;
using System.IO;
using Practica1;

namespace Practica1
{
    public class Program
    {
        static void Main()
        {
            // Rutas de los archivos
            string mesasFilePath = "mesas.txt";
            string pedidosFilePath = "pedidos.txt";
            string meserosFilePath = "meseros.txt";

            // Leer los datos
            List<Mesa> mesas = ReadMesas(mesasFilePath);
            List<Pedido> pedidos = ReadPedidos(pedidosFilePath);
            List<Mesero> meseros = ReadMeseros(meserosFilePath);

            Restaurante restaurante = new Restaurante(mesas, meseros, pedidos);
            restaurante.elegir_usuario()
        }

        static List<Mesa> ReadMesas(string filePath)
        {
            List<Mesa> mesas = new List<Mesa>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Mesa mesa = new Mesa(line);
                        mesas.Add(mesa);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"El archivo de mesas no se pudo leer: {e.Message}");
            }

            return mesas;
        }

        static List<Pedido> ReadPedidos(string filePath)
        {
            List<Pedido> pedidos = new List<Pedido>();

            // Definir los precios de los productos
            Dictionary<string, float> precios_productos = new Dictionary<string, float>
            {
                { "Pizza", 40000 },
                { "Pasta", 30000 },
                { "Ensalada", 20000 },
                { "Refresco", 10000 },
                { "Hamburguesa", 35000 },
                { "Nachos", 25000 },
                { "Sopa", 15000 },
                { "Tacos", 12000 }
            };

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string id = parts[0];
                        string[] productos_nombres = parts[1].Split(',');
                        string[] cantidades_str = parts[2].Split(',');
                        float total = float.Parse(parts[3].Replace(",", string.Empty));

                        List<Producto> productos = new List<Producto>();
                        List<int> cantidades = new List<int>();

                        for (int i = 0; i < productos_nombres.Length; i++)
                        {
                            string nombre_producto = productos_nombres[i];
                            int cantidad = int.Parse(cantidades_str[i]);
                            if (precios_productos.TryGetValue(nombre_producto, out float precio))
                            {
                                productos.Add(new Producto(nombre_producto, precio));
                                cantidades.Add(cantidad);
                            }
                        }

                        Pedido pedido = new Pedido(id, productos, cantidades, total);
                        pedidos.Add(pedido);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"El archivo de pedidos no se pudo leer: {e.Message}");
            }

            return pedidos;
        }

        static List<Mesero> ReadMeseros(string filePath)
        {
            List<Mesero> meseros = new List<Mesero>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string id = parts[0];
                        string nombre = parts[1];

                        Mesero mesero = new Mesero(id, nombre);
                        meseros.Add(mesero);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"El archivo de meseros no se pudo leer: {e.Message}");
            }

            return meseros;
        }
    }
}