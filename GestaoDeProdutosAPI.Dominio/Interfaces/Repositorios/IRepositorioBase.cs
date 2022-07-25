

using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Dominio.Interfaces
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class 
    {
        void Adicionar(TEntidade obj);
        void Alterar(TEntidade obj);
        void Excluir(TEntidade obj);
        TEntidade GetPorId(int id);
        IEnumerable<TEntidade> GetTodos();

        void Dispose();
    }
}
