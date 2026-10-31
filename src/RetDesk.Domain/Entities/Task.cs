using RetDesk.Domain.Common;

namespace RetDesk.Domain.Entities;

public class Task : TenantEntity
{
    public Guid WorkOrderId { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsCompleted { get; set; } = false;
}