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

    public int WorkOrderNumber { get; set; }

    public DateTime Date { get; set; }

    public ClientModel Client { get; set; } = new ClientModel();

    [MaxLength(400)]
    public string WorkDescription { get; set; } = string.Empty;

    public List<SparePartModel> SpareParts { get; set; } = new List<SparePartModel>();
}
