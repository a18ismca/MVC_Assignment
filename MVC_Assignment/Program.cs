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

/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller?}/{action=GuessingGame}/{id?}"
    );
*/

app.UseSession();

app.MapControllerRoute(
    name: "fever",
    pattern: "fever",
    defaults: new { controller = "Doctor", action = "FeverCheck" });

app.MapControllerRoute(
    name: "Guess",
    pattern: "{controller=Guess}/{action=GuessingGame}/{id?}"
    );

app.Run();
