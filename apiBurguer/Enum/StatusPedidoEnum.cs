using System.ComponentModel;

namespace apiBurguer.Enum
{
    public enum StatusPedidoEnum
    {
        [Description("Confirmando pagamento")]
        Pagando = 1,
        [Description("Pagamento confirmado, pedido sendo preparado")]
        AFazer = 2,
        [Description("Pedido saindo para entrega")]
        Enviando = 3
    }
}
