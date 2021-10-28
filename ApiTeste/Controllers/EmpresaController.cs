using ApiTeste.Context;
using ApiTeste.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly TesteContext _context;
        public EmpresaController(TesteContext context)
        {
            _context = context;
        }
        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<Empresa> Get()
        {
            var empresas = _context.Empresas.ToList();
            return empresas;
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public Empresa Get(int id)
        {
            var empresa = _context.Empresas.Find(id);
            return empresa;
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public void Post([FromBody] Empresa empresa)
        {
            _context.Add(empresa);
            _context.SaveChanges();
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string empresa)
        {
            //var empresaUpdate = _context.Empresas.Find(id);
            
            //_context.SaveChanges();
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var empresa = _context.Empresas.Find(id);
            _context.Empresas.Remove(empresa);
        }
    }
}
