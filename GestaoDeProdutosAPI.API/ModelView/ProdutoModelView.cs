using System;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutosAPI.API.ModelView
{
    public class ProdutoModelView
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Erro! A Descrição do Produto Não Foi Preenchida.")]
        [MaxLength(100, ErrorMessage = "Erro! Valor muito grande para o Campo Descrição.")]
        public string Descricao { get; set; }

        [Range(typeof(string), "Ativo", "Inativo")]
        public string Situacao { get; set; }

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataFabricacao { get; set; }

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
        public virtual FornecedorModelView Fornecedor { get; set; }
    }
}
