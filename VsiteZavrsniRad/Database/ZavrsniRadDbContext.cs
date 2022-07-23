
using Microsoft.EntityFrameworkCore;
using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database;

public class ZavrsniRadDbContext : DbContext
{
    public ZavrsniRadDbContext(DbContextOptions<ZavrsniRadDbContext> options) : base(options) { }

    public DbSet<ClientModel>? Clients { get; set; }
    public DbSet<SparePartModel>? SpareParts { get; set; }
    public DbSet<WorkOrderModel>? WorkOrders { get; set; }
    public DbSet<SparePart_WorkOrder>? SparePart_WorkOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SparePart_WorkOrder>()
            .HasOne(s => s.SparePart)
            .WithMany(sw => sw.SparePart_WorkOrders)
            .HasForeignKey(si => si.SparePartId);

        modelBuilder.Entity<SparePart_WorkOrder>()
            .HasOne(w => w.WorkOrder)
            .WithMany(sw => sw.SparePart_WorkOrders)
            .HasForeignKey(si => si.WorkOrderId);
    }
}
