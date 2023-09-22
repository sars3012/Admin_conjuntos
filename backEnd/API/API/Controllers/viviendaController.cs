using adConjuntos2.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adConjuntos2.controllers
{
    [Route("api/vivienda")]
    [ApiController]
    public class viviendaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public viviendaController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Vivienda>> GetVivienda()
        {
            var viviendas = _context.Vivienda.ToList();
            return Ok(viviendas);
        }
    }
}
