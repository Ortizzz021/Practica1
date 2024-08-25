using System;

public class Pedido
{
	private string id;
	private Mesa mesa;
	private list<Producto> productos;
	private list<int> cantidad;
	private float total = 0;

	public Pedido(string id, Mesa mesa, list<Producto> productos, list<int> cantidad)
	{
		this.id = id;
		this.mesa = mesa;
		this.productos = productos;
		this.cantidad = cantidad;
	}

	public float calcular_total()
	{

	}
}
