using FBUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public UsuariosController(AplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try{
                var listUsuarios = await _context.Usuarios.ToListAsync();
                return Ok(listUsuarios);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuarios newusuario)
        {
            try
            {
                _context.Add(newusuario);
                await _context.SaveChangesAsync();
                return Ok(newusuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Usuarios editusuario)
        {
            try
            {
                if(id != editusuario.Id)
                {
                    return NotFound();
                }
                _context.Update(editusuario);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El usuario fue actualizado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteusuario = await _context.Usuarios.FindAsync(id);
                if (deleteusuario == null)
                {
                    return NotFound();
                }
                _context.Usuarios.Remove(deleteusuario);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El usuario fue eliminado con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
