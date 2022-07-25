using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutosAPI.API.Modelos
{
    public class ProdutoVisaoModelo
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Erro! A Descrição do Produto Não Foi Preenchida.")]
        [MaxLength(100, ErrorMessage = "Erro! Valor muito grande para o Campo Descrição.")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
