

using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Dominio.Entidades
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}
