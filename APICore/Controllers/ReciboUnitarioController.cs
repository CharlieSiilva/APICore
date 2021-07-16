using APICore.Contexts;
using APICore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciboUnitarioController : ControllerBase
    {

        private readonly AppDbContext context;

        public ReciboUnitarioController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<ReciboUnitarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReciboUnitarioController>/5
        [HttpGet("{id}")]
        public Recibos Get(int id)
        {
            var recibo = context.Recibos.FirstOrDefault(p => p.IdRecibo == id);
            return recibo;
        }

        // POST api/<ReciboUnitarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReciboUnitarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReciboUnitarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
