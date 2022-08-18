var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Doctor}/{action=FeverCheck}/{id?}"
    );

app.MapControllerRoute(
    name: "fever",
    pattern: "fever",
    defaults: new { controller = "Doctor", action = "FeverCheck" });

app.Run();
