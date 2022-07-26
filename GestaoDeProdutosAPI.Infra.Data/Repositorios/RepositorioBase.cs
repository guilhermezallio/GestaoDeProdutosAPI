
using GestaoDeProdutosAPI.Dominio.Interfaces;
using GestaoDeProdutosAPI.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestaoDeProdutosAPI.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IDisposable, IRepositorioBase<TEntidade> where TEntidade : class
    {
        protected GestaoDeProdutosContext DB = new GestaoDeProdutosContext();

        public void Adicionar(TEntidade obj)
        {
            DB.Set<TEntidade>().Add(obj);
            DB.SaveChanges();
        }

        public void Alterar(TEntidade obj)
        {
            DB.Entry(obj).State = EntityState.Modified;
            DB.SaveChanges();
        }

        public void Dispose()
        {
            DB.Dispose();
        }

        public void Excluir(TEntidade obj)
        {
            DB.Set<TEntidade>().Remove(obj);
            DB.SaveChanges();
        }

        public TEntidade GetPorId(int id)
        {
            return DB.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> GetTodos()
        {
            return DB.Set<TEntidade>().ToList();
        }
    }
}
