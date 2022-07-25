using GestaoDeProdutosAPI.API.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestaoDeProdutosAPI.API.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosControlador : ControllerBase
    {
        // GET: api/<ProdutosControlador>
        [HttpGet]
        public IEnumerable<ProdutoVisaoModelo> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProdutosControlador>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutosControlador>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutosControlador>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutosControlador>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
