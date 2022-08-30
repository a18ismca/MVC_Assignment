var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();



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
