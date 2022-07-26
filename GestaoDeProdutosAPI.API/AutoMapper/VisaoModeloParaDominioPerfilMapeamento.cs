using AutoMapper;
using GestaoDeProdutosAPI.API.ModelView;
using GestaoDeProdutosAPI.Dominio.Entidades;

namespace GestaoDeProdutosAPI.API.AutoMapper
{
    public class VisaoModeloParaDominioPerfilMapeamento : Profile
    {
        public VisaoModeloParaDominioPerfilMapeamento()
        {
            CreateMap<Produto, ProdutoModelView>();
            CreateMap<Fornecedor, FornecedorModelView>();
        }
        public override string ProfileName
        {
            get { return "VisaoModeloParaDominioMapeamento"; }
        }
    }
}
