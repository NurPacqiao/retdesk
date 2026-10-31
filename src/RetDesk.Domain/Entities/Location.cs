using RetDesk.Domain.Common;

namespace RetDesk.Domain.Entities;

public class Location : TenantEntity
{
    public Guid CustomerId { get; set; }
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
}