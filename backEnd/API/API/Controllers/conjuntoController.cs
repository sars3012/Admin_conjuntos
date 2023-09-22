using adConjuntos2.Models;
using adConjuntos2.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adConjuntos2.controllers
{
    [Route("api/conjunto")]
    [ApiController]
    public class conjuntoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public conjuntoController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CrearConjuntoDTO crearConjuntoDTO)
        {
            var conjuntos = _mapper.Map<Conjunto>(crearConjuntoDTO);
            _context.Add(conjuntos);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Conjunto>> GetConjunto()
        {
            var conjuntos = _context.Conjunto.ToList();
            return Ok(conjuntos);
        }
    }
}
