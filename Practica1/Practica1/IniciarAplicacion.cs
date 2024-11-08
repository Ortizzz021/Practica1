using Practica1.Pratica1;

namespace Practica1.Practica1
{
    public class IniciarAplicacion
    {
        public static void Iniciar()
        {
            string mesas_ruta_archivo = "mesas.txt";
            string pedidos_ruta_archivo = "pedidos.txt";
            string meseros_ruta_archivo = "meseros.txt";

            List<Mesa> mesas = leer_mesas(mesas_ruta_archivo);
            List<Pedido> pedidos = leer_pedidos(pedidos_ruta_archivo);
            List<Mesero> meseros = leer_meseros(meseros_ruta_archivo);

            Bar bar = new Bar(mesas, meseros, pedidos);
            bar.elegir_usuario();
        }

        static List<Mesa> leer_mesas(string ruta_archivo)
        {
            List<Mesa> mesas = new List<Mesa>();

            try
            {
                using (StreamReader sr = new StreamReader(ruta_archivo))
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

        static List<Pedido> leer_pedidos(string ruta_archivo)
        {
            List<Pedido> pedidos = new List<Pedido>();

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
                using (StreamReader sr = new StreamReader(ruta_archivo))
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

        static List<Mesero> leer_meseros(string ruta_archivo)
        {
            List<Mesero> meseros = new List<Mesero>();

            try
            {
                using (StreamReader sr = new StreamReader(ruta_archivo))
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
