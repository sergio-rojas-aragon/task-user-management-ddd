
namespace TUM.Domain.Entities
{ 
    public class Rol
    {

        public int RolId { get; set; }

        public string Nombre { get; set; }

        // Relacion uno a muchos
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    }
}
