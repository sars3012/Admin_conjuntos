using System.ComponentModel.DataAnnotations;

namespace adConjuntos2.Models.DTO
{
    public class EliminarConjuntoDTO
    {
        [StringLength(maximumLength: 10)]
        public string cedula_usuario { get; set; }
    }
}
