namespace adConjuntos2.Models
{
    public class Rol
    {
        public int rolId { get; set; }
        public string nombre_rol { get; set; }
        public List<Usuario_rol> Usuario_rol { get; set;}
    }
}
