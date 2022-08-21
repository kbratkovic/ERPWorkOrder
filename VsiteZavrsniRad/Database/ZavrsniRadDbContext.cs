
using Microsoft.EntityFrameworkCore;
using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database;

public class ZavrsniRadDbContext : DbContext
{
    public ZavrsniRadDbContext(DbContextOptions<ZavrsniRadDbContext> options) : base(options) { }

    public DbSet<ClientModel>? Clients { get; set; }
    public DbSet<SparePartModel>? SpareParts { get; set; }
    public DbSet<WorkOrderModel>? WorkOrders { get; set; }
    public DbSet<SparePart_WorkOrderModel>? SparePart_WorkOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SparePart_WorkOrderModel>()
            .HasOne(s => s.SparePart)
            .WithMany(sw => sw.SparePart_WorkOrders)
            .HasForeignKey(si => si.SparePartId);

        modelBuilder.Entity<SparePart_WorkOrderModel>()
            .HasOne(w => w.WorkOrder)
            .WithMany(sw => sw.SparePart_WorkOrders)
            .HasForeignKey(si => si.WorkOrderId);

        modelBuilder.Entity<SparePartModel>()
            .Property(p => p.PriceWithoutVAT)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<SparePartModel>()
            .Property(p => p.PriceWithVAT)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<WorkOrderModel>()
            .Property(w => w.TotalpriceWithoutVAT)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<SparePart_WorkOrderModel>()
            .Property(sw => sw.PriceWithoutVAT)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<SparePart_WorkOrderModel>()
            .Property(sw => sw.PriceWithVAT)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<SparePart_WorkOrderModel>()
            .Property(sw => sw.TotalPriceWithoutVAT)
            .HasColumnType("decimal(18,2)");
    }
}
