using AutoMapper;
using GestaoDeProdutosAPI.API.AutoMapper;
using GestaoDeProdutosAPI.API.Model;
using GestaoDeProdutosAPI.API.ModelView;
using GestaoDeProdutosAPI.Aplicacao.Interfaces;
using GestaoDeProdutosAPI.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GestaoDeProdutosAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorAppServico _appFornecedor;
        private Mapper _map = new Mapper(AutoMapperConfig.RegistrarMapeamentos());

        public FornecedorController(IFornecedorAppServico appFornecedor)
        {
            _appFornecedor = appFornecedor;
        }

        //Obter Todos
        [HttpGet]
        public IEnumerable<FornecedorModelView> GetTodos()
        {
            return _map.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorModelView>>(_appFornecedor.GetTodos());
        }

        //Obter Por ID
        [Route("{id}")]
        [HttpGet]
        public FornecedorModelView GetPorId(int id)
        {
            return _map.Map<Fornecedor, FornecedorModelView>(_appFornecedor.GetPorId(id));
        }

        //Inserir
        [HttpPost]
        public ActionResult Cadastrar([FromBody] FornecedorModel fornecedor)
        {
            try
            {
                _appFornecedor.Adicionar(_map.Map<FornecedorModel, Fornecedor>(fornecedor));
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
        public ActionResult Alterar([FromBody] FornecedorModel fornecedor)
        {
            try
            {
                _appFornecedor.Alterar(_map.Map<FornecedorModel, Fornecedor>(fornecedor));
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
                _appFornecedor.Excluir(_appFornecedor.GetPorId(id));
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
