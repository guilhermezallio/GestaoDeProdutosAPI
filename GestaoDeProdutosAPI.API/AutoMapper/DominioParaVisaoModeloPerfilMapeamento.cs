using AutoMapper;
using GestaoDeProdutosAPI.API.Modelos;
using GestaoDeProdutosAPI.API.VisaoModelos;
using GestaoDeProdutosAPI.Dominio.Entidades;

namespace GestaoDeProdutosAPI.API.AutoMapper
{
    public class DominioParaVisaoModeloPerfilMapeamento : Profile
    {
        public DominioParaVisaoModeloPerfilMapeamento()
        {
            CreateMap<ProdutoVisaoModelo, Produto>();
            CreateMap<FornecedorVisaoModelo, Fornecedor>();
        }
        public override string ProfileName
        {
            get { return "DominioParaVisaoModeloMapeamento"; }
        }

    }
}
