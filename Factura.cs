using System;

public class Factura
{
	private string id;
	private Pedido pedido;
	private float propina;
	private float total = 0;

	public Factura(string id, Pedido pedido, float propina)
	{
		this.id = id;
		this.pedido = pedido;
		this.propina = propina;
	}

	public float calcular_total()
	{

	}
}
