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

    [Required]
    [MaxLength(100)]
    public string CompanyName { get; set; } = String.Empty;

    [Required]
    [MaxLength(11)]
    public string TaxNumber { get; set; } = String.Empty;

    [Required]
    [MaxLength(50)]
    public string City { get; set; } = String.Empty;

    [Required]
    [MaxLength(200)]
    public string Address { get; set; } = String.Empty;

    [MaxLength(60)]
    public string ContactPerson { get; set; } = String.Empty;

    [MaxLength(25)]
    public string PhoneNumber { get; set; } = String.Empty;
}
