using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.WorkOrder;

public interface IWorkOrderRepository
{
    IQueryable<WorkOrderModel> WorkOrders { get; }

    void CreateWorkOrder(WorkOrderModel workOrder);
    void SaveWorkOrder(WorkOrderModel workOrder);
}
