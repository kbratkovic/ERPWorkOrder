using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VsiteZavrsniRad.Models;

public class SparePart_WorkOrderModel
{
    public int Id { get; set; }

    public int SparePartId { get; set; }

    public int WorkOrderId { get; set; }

    public string Code { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public string UnitOfMeasure { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal PriceWithoutVAT { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PriceWithVAT { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPriceWithoutVAT { get; set; }



    [ForeignKey("Id")]
    public SparePartModel? SparePart { get; set; }

    [ForeignKey("Id")]
    public WorkOrderModel? WorkOrder { get; set; }
}
