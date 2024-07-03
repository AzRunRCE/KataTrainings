using Gestion_BU.Core.Interfaces;
using Gestion_BU.Core.Services;
using Gestion_BU.Infrastructure;
using Gestion_BU.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<RegistreService>();
builder.Services.AddScoped<IUniversiteRepository, UniversiteRepository>();
builder.Services.AddScoped<IEtudiantRepository,EtudiantRepository>();
builder.Services.AddScoped<Gestion_BU.Core.Interfaces.ILogger, ConsoleLogger>();

builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();


app.Run();
