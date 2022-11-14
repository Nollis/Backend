using Assignment1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "GuessingGame",
    pattern: "GuessingGame",
    defaults: new { controller = "Guess", action = "NumbGuess" });

app.MapControllerRoute(
    name: "checktemp",
    pattern: "checktemp",
    defaults: new { controller = "Check", action = "CheckTemp" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
