using GestaoDeProdutosAPI.Dominio.Entidades;
using GestaoDeProdutosAPI.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoDeProdutosAPI.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public IEnumerable<Produto> GetTodosPaginado(Produto filtro, int pagina, int numeroRegistros)
        {
            DateTime dataVazia = new DateTime(1, 1, 1, 0, 0, 0);

            return DB.Produtos
                .Where( x =>
                        ((x.ProdutoID == filtro.ProdutoID && filtro.ProdutoID > 0) || filtro.ProdutoID == 0) &&
                        (x.Descricao.Contains(filtro.Descricao)) &&
                        (x.Situacao == filtro.Situacao) &&
                        ((x.DataFabricacao.Day == filtro.DataFabricacao.Day && x.DataFabricacao.Month == filtro.DataFabricacao.Month && x.DataFabricacao.Year == filtro.DataFabricacao.Year && filtro.DataFabricacao != dataVazia) || filtro.DataFabricacao == dataVazia) &&
                        ((x.DataValidade.Day == filtro.DataValidade.Day && x.DataValidade.Month == filtro.DataValidade.Month && x.DataValidade.Year == filtro.DataValidade.Year && filtro.DataValidade != dataVazia) || filtro.DataValidade == dataVazia) &&
                        ((x.FornecedorID == filtro.FornecedorID && filtro.FornecedorID > 0) || filtro.FornecedorID == 0 ) &&
                        (x.Fornecedor.Descricao.Contains(filtro.Fornecedor.Descricao)) &&
                        ((x.Fornecedor.CNPJ == filtro.Fornecedor.CNPJ && String.IsNullOrWhiteSpace(filtro.Fornecedor.CNPJ) == false) || String.IsNullOrWhiteSpace(filtro.Fornecedor.CNPJ))
                      )
                .Skip(((pagina - 1) * numeroRegistros))
                .Take(numeroRegistros)
                .ToList();
        }

        public void ExcluirLogico(int id)
        {
            Produto registro = DB.Produtos.FirstOrDefault(r => r.ProdutoID == id);
            if(registro == null)
            {
                throw new KeyNotFoundException("Erro! Registro não encontrado com esse ID!");
            }
            else
            {
                DB.Produtos.Find(id).Situacao = "Inativo";
                DB.SaveChanges();
            }
        }
    }
}
