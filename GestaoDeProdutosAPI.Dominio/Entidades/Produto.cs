
using System;

namespace GestaoDeProdutosAPI.Dominio.Entidades
{
    public class Produto
    {
        private string _situacao;
        private DateTime _dataFabricacao;
        private DateTime _dataValidade;

        public int ProdutoID { get; set; }
        public string Descricao { get; set; }
        public string Situacao 
        { 
            get { return _situacao; }
            set 
            {
                if (value.ToUpper() != "ATIVO" && value.ToUpper() != "INATIVO")
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        _situacao = "Ativo";
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Erro! O Campo de Situação Pode ser Preenchido Apenas com os Valores: Ativo, Inativo");
                    }
                }
                else
                {
                    if (value.ToUpper() == "ATIVO")
                    {
                        _situacao = "Ativo";
                    }
                    else
                    {
                        _situacao = "Inativo";
                    }
                }

            } 
        }
        public DateTime DataFabricacao 
        {
            get { return _dataFabricacao; } 
            set
            {
                DateTime dataVazia = new DateTime(1, 1, 1, 0, 0, 0);
                if (value != dataVazia && DataValidade != dataVazia)
                {
                    if (value >= DataValidade)
                    {
                        throw new ArgumentOutOfRangeException("Erro! A data de fabricação não pode ser menor que a data de validade do produto!");
                    }
                }

                _dataFabricacao = value;
            }
        }
        public DateTime DataValidade 
        { 
            get { return _dataValidade; }
            set
            {
                DateTime dataVazia = new DateTime(1, 1, 1, 0, 0, 0);
                if (value != dataVazia && DataFabricacao != dataVazia)
                {
                    if (DataFabricacao >= value)
                    {
                        throw new ArgumentOutOfRangeException("Erro! A data de fabricação não pode ser menor que a data de validade do produto!");
                    }
                }

                _dataValidade = value;
            } 
        
        }
        public int FornecedorID { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }

    }
}
