
namespace TUM.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // Relacion uno a muchos
        public ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();

        // claves foraneas
        public int RolId { get; set; }
        public Rol Rol { get; set; } = null!;

    }
}
