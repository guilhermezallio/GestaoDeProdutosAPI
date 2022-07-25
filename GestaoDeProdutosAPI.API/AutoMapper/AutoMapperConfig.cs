using AutoMapper;

namespace GestaoDeProdutosAPI.API.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistrarMapeamentos()
        {
            MapperConfiguration cfg = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DominioParaVisaoModeloPerfilMapeamento>();
                cfg.AddProfile<VisaoModeloParaDominioPerfilMapeamento>();
            });
        }
    }
}
