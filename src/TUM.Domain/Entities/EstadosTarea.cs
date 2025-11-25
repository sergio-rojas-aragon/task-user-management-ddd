

namespace TUM.Domain.Entities
{
    public class EstadosTarea
    {
        public int EstadosTareaId { get; set; }
        public string Nombre { get; set; }

        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; } = null!;
        public DateTime? LastModifiedAt { get; set; }

        // relacion uno a muchos
        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
