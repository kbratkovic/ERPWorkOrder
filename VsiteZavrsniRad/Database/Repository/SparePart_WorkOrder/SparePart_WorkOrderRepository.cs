using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.SparePart_WorkOrder;

public class SparePart_WorkOrderRepository : ISparePart_WorkOrderRepository
{
    private ZavrsniRadDbContext _dbContext;

    public SparePart_WorkOrderRepository(ZavrsniRadDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<SparePart_WorkOrderModel> SpareParts_WorkOrders => _dbContext.SparePart_WorkOrders;

}
