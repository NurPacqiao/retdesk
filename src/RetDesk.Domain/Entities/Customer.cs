using RetDesk.Domain.Common;

namespace RetDesk.Domain.Entities;

public class Customer : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}