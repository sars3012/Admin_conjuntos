using System.ComponentModel.DataAnnotations;

namespace adConjuntos2.Models.DTO
{
    public class CrearUsuarioDTO
    {
        [StringLength(maximumLength: 10)]
        public string tipDoc_usuario { get; set; }
        [StringLength(maximumLength: 10)]
        public string cedula_usuario { get; set; }
        [StringLength(maximumLength: 20)]
        public string nombre1_usuario { get; set; }
        [StringLength(maximumLength: 20)]
        public string? nombre2_usuario { get; set; }
        [StringLength(maximumLength: 20)]
        public string apellido1_usuario { get; set; }
        [StringLength(maximumLength: 20)]
        public string? apellido2_usuario { get; set; }
        [StringLength(maximumLength: 50)]
        public string email_usuario { get; set; }
        public DateTime fechaNac_usuario { get; set; }
        public int telefono_usuario { get; set; }
        [StringLength(maximumLength: 12)]
        public string contrasena { get; set; }
        public CrearUsuarioRolDTO crearUsuarioRolDTO { get; set; }
    }
}
