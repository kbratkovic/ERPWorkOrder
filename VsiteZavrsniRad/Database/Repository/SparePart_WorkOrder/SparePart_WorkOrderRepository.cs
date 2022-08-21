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

    public void CreateSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder)
    {
        _dbContext.Add(sparePart_workOrder);
        _dbContext.SaveChanges();
    }

    public void DeleteSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder)
    {
        _dbContext.Remove(sparePart_workOrder);
        _dbContext.SaveChanges();
    }

    public void SaveSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder)
    {
        _dbContext.SaveChanges();
    }
}
