using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.SparePart_WorkOrder;

public interface ISparePart_WorkOrderRepository
{
    IQueryable<SparePart_WorkOrderModel> SpareParts_WorkOrders { get; }

    void DeleteSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder);
    void SaveSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder);

}
