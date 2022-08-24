var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(15);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.MapControllerRoute(
    name: "fever",
    pattern: "fever",
    defaults: new { controller = "Doctor", action = "FeverCheck" });

app.MapControllerRoute(
    name: "Guess",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
