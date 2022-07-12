
using Microsoft.EntityFrameworkCore;
using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database;

public class ZavrsniRadDbContext : DbContext
{
    public ZavrsniRadDbContext(DbContextOptions<ZavrsniRadDbContext> options) : base(options) { }

    public DbSet<ClientModel>? Clients { get; set; }
    public DbSet<SparePartModel>? SpareParts { get; set; }
    public DbSet<WorkOrderModel>? WorkOrders { get; set; }
}
