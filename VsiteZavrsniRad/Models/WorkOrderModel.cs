using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsiteZavrsniRad.Models;

public class WorkOrderModel
{
    public int Id { get; set; }

    public string WorkOrderNumber { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    [MaxLength(100)]
    public string ServiceItem { get; set; } = string.Empty;

    [Required(ErrorMessage = "Status naloga je obavezan")]
    [MaxLength(50)]
    public string WorkOrderStatus { get; set; } = string.Empty;

    [MaxLength(500)]
    public string WorkDescription { get; set; } = string.Empty;


    // Navigation Properties
    public int ClientId { get; set; }
    public ClientModel Client { get; set; } = new ClientModel();
    public List<SparePart_WorkOrder> SparePart_WorkOrders { get; set; } = new List<SparePart_WorkOrder>();


}
