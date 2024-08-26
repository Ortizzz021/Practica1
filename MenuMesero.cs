using System;

namespace Practica1

public class MenuMesero
{
	private Mesero mesero;

	public MenuMesero(Mesero mesero)
	{
		this.mesero = mesero;
	}

	public void tomar_pedido(string id, Mesa mesa, list<Producto> productos, list<int> cantidad)
	{

	}

    public void registrar_pedido(Pedido pedido)
    {
        mesero.registrar_pedido(pedido);
    }

    public Factura liquidar_factura(Pedido pedido_a_facturar)
    {
        mesero.liquidar_factura();
    }

    public float calcular_propina(Pedido pedido)
    {
        mesero.calcular_propina(pedido);
    }

    public int mesas_atendidas()
    {
        mesero.mesas_atendidas();
    }

    public void opciones_mesero()
    {
        
    }
}
