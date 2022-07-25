namespace GestaoDeProdutosAPI.API.VisaoModelos
{
    public class FornecedorVisaoModelo
    {
        public int FornecedorID { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}
