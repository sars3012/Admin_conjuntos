namespace adConjuntos2.Models.DTO
{
    public class EditarUsuarioDTO
    {
        public string tipDoc_usuario { get; set; }
        public string cedula_usuario { get; set; }
        public string nombre1_usuario { get; set; }
        public string? nombre2_usuario { get; set; }
        public string apellido1_usuario { get; set; }
        public string? apellido2_usuario { get; set; }
        public string email_usuario { get; set; }
        public DateTime fechaNac_usuario { get; set; }
        public int telefono_usuario { get; set; }

    }
}
