using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.SparePart_WorkOrder;

public interface ISparePart_WorkOrderRepository
{
    IQueryable<SparePart_WorkOrderModel> SpareParts_WorkOrders { get; }

    void CreateSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder);
    void SaveSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder);
    void DeleteSparePart_WorkOrder(SparePart_WorkOrderModel sparePart_workOrder);

}
