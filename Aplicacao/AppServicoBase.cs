using GestaoDeProdutosAPI.Aplicacao.Interfaces;
using GestaoDeProdutosAPI.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Aplicacao
{
    public class AppServicoBase<TEntidade> : IDisposable, IAppServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IServicoBase<TEntidade> _servicoBase;

        public AppServicoBase(IServicoBase<TEntidade> servicoBase)
        {
            _servicoBase = servicoBase;
        }

        public void Adicionar(TEntidade obj)
        {
            _servicoBase.Adicionar(obj);
        }

        public void Alterar(TEntidade obj)
        {
            _servicoBase.Alterar(obj);
        }

        public void Dispose()
        {
            _servicoBase.Dispose();
        }

        public void Excluir(TEntidade obj)
        {
            _servicoBase.Excluir(obj);
        }

        public TEntidade GetPorId(int id)
        {
            return _servicoBase.GetPorId(id);
        }

        public IEnumerable<TEntidade> GetTodos()
        {
            return _servicoBase.GetTodos();
        }
    }
}
