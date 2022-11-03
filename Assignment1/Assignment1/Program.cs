var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "checkage",
    pattern: "checkage",
    defaults: new { controller = "Check", action = "CheckTemp" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
