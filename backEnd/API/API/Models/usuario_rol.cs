using System.ComponentModel.DataAnnotations;

namespace adConjuntos2.Models
{
    public class Usuario_rol
    {
        [Key]
        public int usuarioRolId { get; set; }
        public int usuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int rolId { get; set; }
        public Rol Rol { get; set; }
        public int conjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
