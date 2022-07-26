using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutosAPI.API.ModelView
{
    public class FornecedorModelView
    {
        [Key]
        public int FornecedorID { get; set; }

        [Required(ErrorMessage = "Erro! A Descrição do Fornecedor Não Foi Preenchida.")]
        [MaxLength(100, ErrorMessage = "Erro! Valor muito grande para o Campo Descrição.")]
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public virtual IEnumerable<ProdutoModelView> Produtos { get; set; }
    }
}
