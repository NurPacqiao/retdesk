using RetDesk.Domain.Common;

namespace RetDesk.Domain.Entities;

public class Project : TenantEntity
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}