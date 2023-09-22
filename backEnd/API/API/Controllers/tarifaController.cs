using adConjuntos2.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adConjuntos2.controllers
{
    [Route("api/tarifa")]
    [ApiController]
    public class tarifaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public tarifaController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Tarifa>> GetTarifa()
        {
            var tarifas = _context.Tarifa.ToList();
            return Ok(tarifas);
        }
    }
}
