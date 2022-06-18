using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsiteZavrsniRad.Models;

public class SparePartModel
{
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Code { get; set; } = String.Empty;

    [Required]
    [MaxLength(200)]
    public string Description { get; set; } = String.Empty;

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal PriceWithoutVAT { get; set; }

    [Required]
    public decimal PriceWithVAT { get; set; }
}
