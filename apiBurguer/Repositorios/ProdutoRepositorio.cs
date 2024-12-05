using apiBurguer.Data;
using apiBurguer.Models;
using apiBurguer.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiBurguer.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BurguerManiaDBContext _dbContext;

        public ProdutoRepositorio(BurguerManiaDBContext burguerManiaDBContext)
        {
            _dbContext = burguerManiaDBContext;
        }

        public async Task<ProdutoModel> BuscarPorId(int id)
        {
            return await _dbContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ProdutoModel>> BuscarTodosProdutos()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProdutoModel> AdicionarItem(ProdutoModel produto)
        {
            await _dbContext.Produtos.AddAsync(produto);
            await _dbContext.SaveChangesAsync();

            return produto;
        }

        public async Task<ProdutoModel> AtualizarItem(ProdutoModel produto, int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);

            if (produtoPorId == null)
            {
                throw new Exception($"Produto para o Id: {id} não foi encontrado no banco de dados.");
            }

            produtoPorId.Nome = produto.Nome;
            produtoPorId.Preco = produto.Preco;
            produtoPorId.Descricao = produto.Descricao;
            produtoPorId.Ingredientes = produto.Ingredientes;

            _dbContext.Produtos.Update(produtoPorId);
            await _dbContext.SaveChangesAsync();

            return produtoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            ProdutoModel produtoPorId = await BuscarPorId(id);

            if (produtoPorId == null)
            {
                throw new Exception($"Produto para o Id: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Produtos.Remove(produtoPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
