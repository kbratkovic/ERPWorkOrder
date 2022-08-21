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
        _dbContext.Add(workOrder);
        _dbContext.SaveChanges();
    }

    public void SaveWorkOrder(WorkOrderModel workOrder)
    {
        _dbContext.SaveChanges();
    }
}
