using GestaoDeProdutosAPI.Dominio.Entidades;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Aplicacao.Interfaces
{
    public interface IProdutoAppServico : IAppServicoBase<Produto>
    {
        IEnumerable<Produto> GetTodosPaginado(Produto filtro, int pagina, int numeroRegistros);

        void ExcluirLogico(int id);
        
    }
}
