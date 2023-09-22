using adConjuntos2.Models;
using adConjuntos2.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace adConjuntos2.controllers
{
    [Route("api/rol")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public RolController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Rol>> GetRol()
        {
            var roles = _context.Usuario.ToList();
            return Ok(roles);
        }
        [HttpPost]
        public async Task<ActionResult> Post(CrearRolDTO crearRolDTO)
        {
            var rol = _mapper.Map<Rol>(crearRolDTO);
            _context.Add(rol);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
