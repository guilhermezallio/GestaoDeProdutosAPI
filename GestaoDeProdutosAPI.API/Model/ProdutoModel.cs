using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutosAPI.API.Model
{
    public class ProdutoModel
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Erro! A Descrição do Produto Não Foi Preenchida.")]
        [MaxLength(100, ErrorMessage = "Erro! Valor muito grande para o Campo Descrição.")]
        public string Descricao { get; set; }
        
        public string Situacao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
    }
}
