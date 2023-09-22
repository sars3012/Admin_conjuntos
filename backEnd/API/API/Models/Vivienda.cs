namespace adConjuntos2.Models
{
    public class Vivienda
    {
        public int viviendaId { get; set; }
        public int numero_vivienda { get; set;  }
        public int usuarioId { get; set; }  
        public Usuario usuario { get; set;}
        public Conjunto Conjunto { get; set; }
        public List<Tarifa> Tarifa { get; set; }

    }
}
