

using GestaoDeProdutosAPI.Dominio.Interfaces;
using GestaoDeProdutosAPI.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IDisposable, IServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IRepositorioBase<TEntidade> _repositorio;
        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(TEntidade obj)
        {
            _repositorio.Adicionar(obj);
        }

        public void Alterar(TEntidade obj)
        {
            _repositorio.Alterar(obj);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public void Excluir(TEntidade obj)
        {
            _repositorio.Excluir(obj);
        }

        public TEntidade GetPorId(int id)
        {
            return _repositorio.GetPorId(id);
        }

        public IEnumerable<TEntidade> GetTodos()
        {
            return _repositorio.GetTodos();
        }
    }
}
