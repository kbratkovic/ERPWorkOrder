using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsiteZavrsniRad.Models;

public class ClientModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Odabir klijenta je obavezan")]
    [MaxLength(100)]
    public string ClientName { get; set; } = string.Empty;

    [MaxLength(11)]
    public string TaxNumber { get; set; } = string.Empty;

    [MaxLength(50)]
    public string City { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Address { get; set; } = string.Empty;

    [MaxLength(60)]
    public string ContactPerson { get; set; } = string.Empty;

    [MaxLength(25)]
    public string PhoneNumber { get; set; } = string.Empty;


    // Navigation Properties
    public List<WorkOrderModel> WorkOrders { get; set; } = new List<WorkOrderModel>();
}
