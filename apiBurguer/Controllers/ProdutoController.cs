using apiBurguer.Models;
using apiBurguer.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apiBurguer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosProdutos()
        {
            List<ProdutoModel> produtos = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarPorId(int id)
        {
            ProdutoModel produto = await _produtoRepositorio.BuscarPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Cadastrar([FromBody] ProdutoModel produtoModel)
        {
            ProdutoModel produto = await _produtoRepositorio.AdicionarItem(produtoModel);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProdutoModel>> Atualizar([FromBody] ProdutoModel produtoModel, int id)
        {
            produtoModel.Id = id;
            ProdutoModel produto = await _produtoRepositorio.AtualizarItem(produtoModel, id);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoModel>> Apagar(int id)
        {
            bool apagado = await _produtoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
