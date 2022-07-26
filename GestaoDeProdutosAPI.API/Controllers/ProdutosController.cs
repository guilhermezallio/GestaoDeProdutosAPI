using AutoMapper;
using GestaoDeProdutosAPI.API.AutoMapper;
using GestaoDeProdutosAPI.API.Model;
using GestaoDeProdutosAPI.API.ModelView;
using GestaoDeProdutosAPI.Aplicacao.Interfaces;
using GestaoDeProdutosAPI.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoAppServico _produtoApp;
        private readonly IFornecedorAppServico _fornecedorApp;
        private Mapper _map = new Mapper(AutoMapperConfig.RegistrarMapeamentos());

        public ProdutosController(IProdutoAppServico produtoApp, IFornecedorAppServico fornecedorApp)
        {
            _produtoApp = produtoApp;
            _fornecedorApp = fornecedorApp;
        }

        //Recuperar um Registro por Código
        [HttpGet]
        [Route("{id}")]
        public ProdutoModelView GetPorCodigo(int id)
        {
            return _map.Map<Produto, ProdutoModelView>(_produtoApp.GetPorId(id));
        }

        //Listar Registros Filtrando a Partir de Parâmetros e paginando a resposta.
        [HttpGet]
        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.Filter | AllowedQueryOptions.Skip | AllowedQueryOptions.Top)]
        public IEnumerable<ProdutoModelView> GetTodosFiltro()
        {
            return _map.Map<IEnumerable<Produto>, IEnumerable<ProdutoModelView>>(_produtoApp.GetTodos());
        }

        //Inserir
        [HttpPost]
        public ActionResult Cadastrar([FromBody] ProdutoModel produto)
        {
            try
            {
                if(_fornecedorApp.GetPorId(produto.FornecedorID) == null)
                {
                    throw new KeyNotFoundException("Erro! Não foi encontrado o fornecedor com o ID inserido. Para encontrar um fornecedor ou cadastrar um novo, Acesse a API de Fornecedor");
                }

                _produtoApp.Adicionar(_map.Map<ProdutoModel, Produto>(produto));
                return Ok("O Cadastro Foi Realizado Com Sucesso");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.InnerException.Message);
                }
                else
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        //Alterar
        [HttpPut]
        public ActionResult Alterar([FromBody] ProdutoModel produto)
        {
            try
            {
                if (_fornecedorApp.GetPorId(produto.FornecedorID) == null)
                {
                    throw new KeyNotFoundException("Erro! Não foi encontrado o fornecedor com o ID inserido. Para encontrar um fornecedor ou cadastrar um novo, Acesse a API de Fornecedor");
                }

                _produtoApp.Alterar(_map.Map<ProdutoModel, Produto>(produto));
                return Ok("O Cadastro Foi Alterado Com Sucesso");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.InnerException.Message);
                }
                else
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        //Excluir
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Excluir(int id)
        {
            try
            {
                _produtoApp.ExcluirLogico(id);
                return Ok("O Cadastro Foi Excluido Com Sucesso");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return BadRequest(ex.InnerException.Message);
                }
                else
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
