using adConjuntos2.Models;
using adConjuntos2.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adConjuntos2.controllers
{
    [Route("api/login")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public loginController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> PostUsuario([FromBody] loginDTO loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.email) || string.IsNullOrEmpty(loginDTO.password))
            {
                var response = new { message = "Correo electrónico y contraseña son requeridos " };
                return Ok(response);
            }

            var user = _db.Usuario.FirstOrDefault(x => x.email_usuario.ToLower() == loginDTO.email.ToLower());

            if (user == null || user.contrasena != loginDTO.password)
            {
                var response1 = new { message = "Correo electrónico o contraseña incorrectos" };
                return Ok(response1);
            }

            var response2 = new { message = "Login Exitoso" };
            return Ok(response2);

        }
    }
}
