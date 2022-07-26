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
    public class FornecedorAppServico : AppServicoBase<Fornecedor>, IFornecedorAppServico
    {
        public readonly IFornecedorServico _fornecedorServico;

        public FornecedorAppServico(IFornecedorServico fornecedorServico)
            : base(fornecedorServico)
        {
            _fornecedorServico = fornecedorServico;
        }
    }
}
