namespace VsiteZavrsniRad.Models;

public class SparePart_WorkOrderModel
{
    public int Id { get; set; }

    public int SparePartId { get; set; }
    public SparePartModel? SparePart { get; set; }

    public int WorkOrderId { get; set; }
    public WorkOrderModel? WorkOrder { get; set; }
}
