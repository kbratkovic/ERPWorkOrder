﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsiteZavrsniRad.Models;

public class SparePartModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Šifra je obavezna")]
    [MaxLength(20)]
    public string Code { get; set; } = string.Empty;

    [Required(ErrorMessage = "Opis je obavezan")]
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Količina je obavezna")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Mjera je obavezna")]
    [MaxLength(10)]
    public string UnitOfMeasure { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    [Required(ErrorMessage = "Veleprodajna cijena je obavezna")]
    public decimal PriceWithoutVAT { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal PriceWithVAT { get; set; }


    // Navigation Properties
    public List<SparePart_WorkOrderModel> SparePart_WorkOrders { get; set; } = new List<SparePart_WorkOrderModel>();
}
