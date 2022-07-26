using GestaoDeProdutosAPI.Aplicacao.Interfaces;
using GestaoDeProdutosAPI.Dominio.Entidades;
using GestaoDeProdutosAPI.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutosAPI.Aplicacao
{
    public class ProdutoAppServico : AppServicoBase<Produto>, IProdutoAppServico
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoAppServico(IProdutoServico produtoServico)
            : base(produtoServico)
        {
            _produtoServico = produtoServico;
        }

        public IEnumerable<Produto> GetTodosPaginado(Produto filtro, int pagina, int numeroRegistros)
        {
            return _produtoServico.GetTodosPaginado(filtro, pagina, numeroRegistros);
        }

        public void ExcluirLogico(int id)
        {
            _produtoServico.ExcluirLogico(id);
        }
    }
}
