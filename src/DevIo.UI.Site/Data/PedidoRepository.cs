using DevIo.UI.Site.Models;

namespace DevIo.UI.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
