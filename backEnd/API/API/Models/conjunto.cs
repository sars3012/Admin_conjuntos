namespace adConjuntos2.Models
{
    public class Conjunto
    {
        public int conjuntoId { get; set; }
        public string nombre_conjunto { get; set; }
        public string direccion_conjunto { get; set; }
        public List<Usuario_rol> Usuario_Rol { get; set; }
        public List<Vivienda> Vivienda { get; set; }
    }
}
