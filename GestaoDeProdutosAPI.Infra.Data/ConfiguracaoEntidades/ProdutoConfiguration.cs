
using GestaoDeProdutosAPI.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeProdutosAPI.Infra.Data.ConfiguracaoEntidades
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.ProdutoID);
            Property(c => c.Descricao).IsRequired();

            HasRequired(c => c.Fornecedor).WithMany().HasForeignKey(c => c.FornecedorID);
        }
    }
}
