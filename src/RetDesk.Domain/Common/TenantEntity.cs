namespace RetDesk.Domain.Common;

public abstract class TenantEntity : BaseEntity
{
    public Guid CompanyId { get; set; }
}