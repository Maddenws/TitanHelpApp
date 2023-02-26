using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TitanHelp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Injecting Razor Pages to container
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TitanHelpContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TitanHelpContext") ?? throw new InvalidOperationException("Connection string 'TitanHelpContext' not found.")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Host.UseSerilog((context, config) =>
{
    config.WriteTo.Console();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//adding RazorPageMapping
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
