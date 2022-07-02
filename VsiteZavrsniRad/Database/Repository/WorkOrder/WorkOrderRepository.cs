using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.WorkOrder;

public class WorkOrderRepository : IWorkOrderRepository
{
    private ZavrsniRadDbContext _dbContext;

    public WorkOrderRepository(ZavrsniRadDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<WorkOrderModel> WorkOrders => _dbContext.WorkOrders;



    public void CreateWorkOrder(WorkOrderModel workOrder)
    {
        throw new NotImplementedException();
    }

    public void SaveWorkOrder(WorkOrderModel workOrder)
    {
        throw new NotImplementedException();
    }
}
