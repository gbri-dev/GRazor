using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GRazor.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<GRazorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GRazorContext") ?? throw new InvalidOperationException("Connection string 'GRazorContext' not found.")));

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<GRazorContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("GRazorContext")));
}
else
{
    builder.Services.AddDbContext<GRazorContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionGRazorContext")));
}
var app = builder.Build();

app.MapRazorPages();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.Run();
