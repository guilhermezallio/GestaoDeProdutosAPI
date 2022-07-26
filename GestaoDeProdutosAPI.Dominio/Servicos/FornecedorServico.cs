using GestaoDeProdutosAPI.Dominio.Entidades;
using GestaoDeProdutosAPI.Dominio.Interfaces;
using GestaoDeProdutosAPI.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutosAPI.Dominio.Servicos
{
    public class FornecedorServico : ServicoBase<Fornecedor>, IFornecedorServico
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorServico(IFornecedorRepositorio fornecedorRepositorio) : base(fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }
    }
}
