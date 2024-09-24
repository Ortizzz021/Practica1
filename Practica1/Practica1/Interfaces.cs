
using Practica1.Pratica1;

namespace Practica1.Practica1
{
    public interface IMesero
    {

        void registrar_pedido(List<Pedido> pedidos, List<Mesa> mesas);
        void liquidar_factura(Mesa mesa);
    }

    public interface IAdministrador
    {
        void visualizar_mesas_atendidas();
        void visualizar_propinas();
        void evaluar_efectividad();
        void visualizar_mesas();
    }

}
