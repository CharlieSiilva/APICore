using APICore.Contexts;
using APICore.Models;
using APICore.Utils;
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
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext context;

        public UsuariosController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            return context.Usuarios.ToList();
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult Post([FromBody] Usuarios usuarios)
        {
            var result = context.Usuarios.Where(p => p.Usuario == usuarios.Usuario).Where(q => q.Password == usuarios.Password).FirstOrDefault<Usuarios>();

            if (result != null){

                APIResponse res = new APIResponse()
                {
                    result = result.IdUsuario,
                    status = 200
                };
                return Ok(res);
            }
            else
            {
                APIResponse res = new APIResponse()
                {
                    msj = "El Usuario no existe o la contraseña es incorrecta",
                    status = 400
                };
                return Ok(res);
            }

        }


        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
