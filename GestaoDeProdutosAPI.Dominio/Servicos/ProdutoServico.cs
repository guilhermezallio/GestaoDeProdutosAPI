using GestaoDeProdutosAPI.Dominio.Entidades;
using GestaoDeProdutosAPI.Dominio.Interfaces;
using GestaoDeProdutosAPI.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Dominio.Servicos
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio) : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IEnumerable<Produto> GetTodosPaginado(Produto filtro, int pagina, int numeroRegistros)
        {
            return _produtoRepositorio.GetTodosPaginado(filtro, pagina, numeroRegistros);
        }

        public void ExcluirLogico(int id)
        {
            _produtoRepositorio.ExcluirLogico(id);
        }
    }
}   
