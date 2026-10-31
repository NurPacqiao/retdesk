using RetDesk.Domain.Common;

namespace RetDesk.Domain.Entities;

public class WorkOrder : TenantEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = "Draft";
    public Guid CustomerId { get; set; }
    public Guid? LocationId { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? AssignedUserId { get; set; }
}