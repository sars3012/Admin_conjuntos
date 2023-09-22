namespace adConjuntos2.Models
{
    public class Tarifa
    {
        public int tarifaId { get; set; }
        public int valor_tarifa { get; set; }
        public string tipo_tarifa { get; set; }
        public int viviendaId { get; set; }
        public Vivienda Vivienda { get; set; }
    }
}
