
namespace TUM.Domain.Entities
{
    public class ClientTypes
    {
        public int ClientTypeId { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }

        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? LastModified { get; set; }
        public DateTime? LastModifiedAt { get; set; }

        public ICollection<Client> Clients { get; set; } = new List<Client>();
    }
}
