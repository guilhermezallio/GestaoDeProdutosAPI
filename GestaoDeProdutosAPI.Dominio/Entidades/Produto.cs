
using System;

namespace GestaoDeProdutosAPI.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int FornecedorID { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

    }
}
