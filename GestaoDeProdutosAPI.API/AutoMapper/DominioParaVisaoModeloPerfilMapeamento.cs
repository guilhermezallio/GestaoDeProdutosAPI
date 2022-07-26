using AutoMapper;
using GestaoDeProdutosAPI.API.Model;
using GestaoDeProdutosAPI.API.ModelView;
using GestaoDeProdutosAPI.Dominio.Entidades;

namespace GestaoDeProdutosAPI.API.AutoMapper
{
    public class DominioParaVisaoModeloPerfilMapeamento : Profile
    {
        public DominioParaVisaoModeloPerfilMapeamento()
        {
            CreateMap<ProdutoModel, Produto>();
            CreateMap<FornecedorModel, Fornecedor>();
        }
        public override string ProfileName
        {
            get { return "DominioParaVisaoModeloMapeamento"; }
        }

    }
}
