using EscoteiroLMS.Domain.Enums;

namespace EscoteiroLMS.Domain.ValueObjects
{
    public class Address
    {
        public string ZipCode { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Neighborhood { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public States State { get; set; }
        public string Complement { get; set; } = string.Empty;
    }
}
