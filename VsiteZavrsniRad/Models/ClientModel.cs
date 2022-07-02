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

    [Required(ErrorMessage = "Ime tvrtke je obavezno")]
    [MaxLength(100)]
    public string CompanyName { get; set; } = String.Empty;

    [Required(ErrorMessage = "OIB je obavezan")]
    [MaxLength(11)]
    public string TaxNumber { get; set; } = String.Empty;

    [Required(ErrorMessage = "Grad je obavezan")]
    [MaxLength(50)]
    public string City { get; set; } = String.Empty;

    [Required(ErrorMessage = "Adresa je obavezna")]
    [MaxLength(200)]
    public string Address { get; set; } = String.Empty;

    [MaxLength(60)]
    public string ContactPerson { get; set; } = String.Empty;

    [MaxLength(25)]
    public string PhoneNumber { get; set; } = String.Empty;
}
