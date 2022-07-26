﻿using GestaoDeProdutosAPI.Dominio.Entidades;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.Dominio.Interfaces
{
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
        IEnumerable<Produto> GetTodosPaginado(Produto filtro, int pagina, int numeroRegistros);

        void ExcluirLogico(int id);
    }
}
