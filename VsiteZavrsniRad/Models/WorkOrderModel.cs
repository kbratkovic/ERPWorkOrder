using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalpriceWithoutVAT { get; set; }


    // Navigation Properties
    public int ClientId { get; set; }

    [Required(ErrorMessage = "Klijent je obavezan")]
    public ClientModel Client { get; set; } = new ClientModel();
    public List<SparePart_WorkOrderModel> SparePart_WorkOrders { get; set; } = new List<SparePart_WorkOrderModel>();


}
