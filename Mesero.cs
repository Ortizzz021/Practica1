using System;

public class Mesero
{
	private string id;
	private string nombre;
	private list<Pedido> pedidos;
	private float propinas = 0;

	public Mesero(string id, string nombre)
	{
		this.id = id;
		this.nombre = nombre;
		pedidos = new list<Pedido>
	}

	public void registrar_pedido(Pedido pedido)
	{

	}

    public Factura liquidar_factura()
    {

    }

    public float calcular_propina(Pedido pedido)
    {

    }

    public int mesas_atendidas()
    {

    }
}
