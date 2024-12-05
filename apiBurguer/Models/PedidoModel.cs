using apiBurguer.Enum;

namespace apiBurguer.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public StatusPedidoEnum Status { get; set; }
        public float Valor { get; set; }
    }
}
