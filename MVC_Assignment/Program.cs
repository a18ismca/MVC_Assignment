using MVC_Assignment.DbData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "fever",
    pattern: "fever",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "Guess",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
