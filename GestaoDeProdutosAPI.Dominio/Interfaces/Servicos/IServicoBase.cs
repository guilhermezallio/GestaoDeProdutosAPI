using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutosAPI.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade obj);
        void Alterar(TEntidade obj);
        void Excluir(TEntidade obj);
        TEntidade GetPorId(int id);
        IEnumerable<TEntidade> GetTodos();

        void Dispose();
    }
}
