using System.ComponentModel.DataAnnotations;

namespace GestaoDeProdutosAPI.API.Model
{
    public class FornecedorModel
    {
        [Key]
        public int FornecedorID { get; set; }

        [Required(ErrorMessage = "Erro! A Descrição do Fornecedor Não Foi Preenchida.")]
        [MaxLength(100, ErrorMessage = "Erro! Valor muito grande para o Campo Descrição.")]
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

    }
}
