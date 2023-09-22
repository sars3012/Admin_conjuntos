using adConjuntos2.Models;
using adConjuntos2.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace adConjuntos2.controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public UsuarioController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CrearUsuarioDTO crearUsuarioDTO)
        {
            /*var contrasena = "";
            try
            {
                encriptar encriptar1 = new encriptar();
                contrasena = encriptar1.Encriptar(_mapper.Map<Usuario>(crearUsuarioDTO.contrasena));
            }
            catch (Exception ex)
            {
                return Ok("error");
            }*/
            var usuario = _mapper.Map<Usuario>(crearUsuarioDTO);
            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok("Usuario Creado");
        }

        [HttpPut]
        public async Task<ActionResult> PutEditarUsuario(string cedula_usuario, EditarUsuarioDTO editarUsuarioDTO)
        {
            if (cedula_usuario == editarUsuarioDTO.cedula_usuario)
            {
                _context.Usuario.ToList();
                _context.Entry(cedula_usuario).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (editarUsuarioDTO.cedula_usuario == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                return BadRequest();
            }

            

            return NoContent();
            /*if(cedula_usuario != editarUsuarioDTO.cedula_usuario)
            {
                return BadRequest();
            }
            else
            {
                _context.Usuario.ToList();
                _context.Entry(editarUsuarioDTO).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return NoContent();*/
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEleminarUsuario(string cedula_usuario)
        {
            var usuario = await _context.Usuario.FindAsync(cedula_usuario);

            if(usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> GetUsuarios()
        {
            var usuarios = _context.Usuario.ToList();
            return Ok(usuarios);
        }
    }
}
