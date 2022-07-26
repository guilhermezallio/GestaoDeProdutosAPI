using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Aplicacao.Interfaces
{
    public interface IAppServicoBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade obj);
        void Alterar(TEntidade obj);
        void Excluir(TEntidade obj);
        TEntidade GetPorId(int id);
        IEnumerable<TEntidade> GetTodos();

        void Dispose();
    }
}
