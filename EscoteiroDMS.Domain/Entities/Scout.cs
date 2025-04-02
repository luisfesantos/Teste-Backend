using EscoteiroLMS.Domain.ValueObjects;
using System.Net;

namespace EscoteiroLMS.Domain.Entities
{
    public sealed class Scout
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public string? Phone { get; set; }
        public string? EmergencyPhone { get; set; }
        public Address Address { get; set; } = default!;
        public Responsible Responsible { get; set; } = default!;
        public int ResponsibleId { get; set; }
    }
}
