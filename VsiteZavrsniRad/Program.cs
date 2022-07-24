using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using VsiteZavrsniRad.Database;
using VsiteZavrsniRad.Database.Repository.Client;
using VsiteZavrsniRad.Database.Repository.SparePart;
using VsiteZavrsniRad.Database.Repository.WorkOrder;
using VsiteZavrsniRad.Models;
using VsiteZavrsniRad.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ClientModel>();
builder.Services.AddScoped<SparePartModel>();
builder.Services.AddScoped<WorkOrderModel>();
builder.Services.AddScoped<SparePart_WorkOrder>();

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ISparePartRepository, SparePartRepository>();
builder.Services.AddScoped<IWorkOrderRepository, WorkOrderRepository>();

builder.Services.AddDbContext<ZavrsniRadDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:DBConnection"]);
});

// Radzen
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
