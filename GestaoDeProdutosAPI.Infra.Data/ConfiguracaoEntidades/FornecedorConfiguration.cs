

using GestaoDeProdutosAPI.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeProdutosAPI.Infra.Data.ConfiguracaoEntidades
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(c => c.FornecedorID);

            Property(c => c.Descricao).IsRequired();
        }
    }
}
