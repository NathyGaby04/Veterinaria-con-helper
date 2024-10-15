using System.ComponentModel.DataAnnotations;

namespace asp_servicios.Nucleo
{
    public class Citas
    {
        [Key] public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Diagnostico { get; set; }
        public int Paciente { get; set; }

    }
}
