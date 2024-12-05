using apiBurguer.Models;

namespace apiBurguer.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<ProdutoModel>> BuscarTodosProdutos();
        Task<ProdutoModel> BuscarPorId(int id);
        Task<ProdutoModel> AdicionarItem(ProdutoModel produto);
        Task<ProdutoModel> AtualizarItem(ProdutoModel produto, int id);
        Task<bool> Apagar(int id);
    }
}
