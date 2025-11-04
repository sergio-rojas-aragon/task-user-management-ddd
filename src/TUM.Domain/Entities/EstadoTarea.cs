

namespace TUM.Domain.Entities
{
    public class EstadoTarea
    {

        public int EstadoTareaId { get; set; }

        public string Nombre { get; set; }

        // relacion uno a muchos
        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
