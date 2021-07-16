using APICore.Contexts;
using APICore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecibosController : ControllerBase
    {
        private readonly AppDbContext context;

        public RecibosController (AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<RecibosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RecibosController>/5
        [HttpGet("{id}")]
        public IEnumerable<Recibos> Get(int id)
        {

            return context.Recibos.Where(p => p.IdUsuario == id).ToList();
        }

        // POST api/<RecibosController>
        [HttpPost]
        public ActionResult Post([FromBody] Recibos recibos)
        {
            context.Recibos.Add(recibos);
            context.SaveChanges();
            return Ok();
        }

        // PUT api/<RecibosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Recibos recibos)
        {
            if (recibos.IdRecibo == id)
            {
                context.Entry(recibos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<RecibosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var recibos = context.Recibos.FirstOrDefault(p => p.IdRecibo == id);
            if(recibos != null)
            {
                context.Recibos.Remove(recibos);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
