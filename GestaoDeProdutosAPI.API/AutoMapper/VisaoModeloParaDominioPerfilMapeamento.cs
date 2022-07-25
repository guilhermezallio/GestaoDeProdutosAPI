using AutoMapper;
using GestaoDeProdutosAPI.API.Modelos;
using GestaoDeProdutosAPI.API.VisaoModelos;
using GestaoDeProdutosAPI.Dominio.Entidades;

namespace GestaoDeProdutosAPI.API.AutoMapper
{
    public class VisaoModeloParaDominioPerfilMapeamento : Profile
    {
        public VisaoModeloParaDominioPerfilMapeamento()
        {
            CreateMap<Produto, ProdutoVisaoModelo>();
            CreateMap<Fornecedor, FornecedorVisaoModelo>();
        }
        public override string ProfileName
        {
            get { return "DominioParaVisaoModeloMapeamento"; }
        }
    }
}
