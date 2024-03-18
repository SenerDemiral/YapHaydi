using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using YapHaydi.Components;
using YapHaydi.Components.Pages;
using YapHaydi.DataLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Configuration.AddJsonFile("C:\\AspNetConfig\\YapHaydi.json",
                       optional: true,
                       reloadOnChange: true);

builder.Services.AddSingleton<IDataAccess, FBDataAccess>();
builder.Services.AddSingleton<IDbCon, DbCon>();

//builder.Services.AddSingleton<IUsrDic, UsrDic>();

// RootLevelCascadingValue 
// https://stackoverflow.com/questions/77426155/how-to-configure-root-level-cascading-values-with-isfixed-in-blazor
// https://www.cazzulino.com/cascading-blazor.html // https://github.com/kzu/CascadingValueNotification/tree/main
// https://github.com/dotnet/aspnetcore/issues/53257
builder.Services.AddScoped((sp) =>
{
    var daleks = new AppState { UsrId = -1, UsrTkn = "Tanımsız" };
    return new CascadingValueSource<AppState>(daleks, isFixed: false);
});
// use
// @inject CascadingValueSource<RLCV> CVS
// CVS?.NotifyChangedAsync();

builder.Services.AddCascadingValue(sp => sp.GetRequiredService<CascadingValueSource<AppState>>());
// use
// [CascadingParameter] public RLCV? rLCV { get; set; }
// rLCV.SetVal(toto.Value.usrid, "Şener");


builder.Services.AddSingleton<INews, News>();

//builder.Services.AddCascadingValue(sp => new RLCV { usrId = -1, usrName="Tanımsız" });
//CascadingValueSource<RLCV> source;
//builder.Services.AddCascadingValue(sp =>
//{
//    //var daleks = new RLCV { usrId = -1, usrName = "Tanımsız" };
//    //var source = new CascadingValueSource<RLCV>(daleks, isFixed: false);

//    var daleks = new DDD { usrId = "Tanımsız" };
//    var source = new CascadingValueSource<DDD>(daleks, isFixed: false);
//    //_ = Task.Run(async () =>
//    //{
//    //    await Task.Delay(5000);
//    //    await source.NotifyChangedAsync(new RLCV { usrId = 1000, usrName = "Dilara" });
//    //});

//    return source;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.Use(async (context, next) =>
{
    //if (context.Request.Cookies["sener"] != "dilara")
    //{
    //    CookieOptions cookieOptions = new CookieOptions();
    //    cookieOptions.Secure = false;
    //    cookieOptions.Expires = DateTime.Now.AddHours(1);
    //    cookieOptions.HttpOnly = true;
    //    cookieOptions.SameSite = SameSiteMode.Strict;
    //    context.Response.Cookies.Append("sener", "dilara", cookieOptions);
    //}

    if (context.Request.Path == "/abidik")
    {
        await context.Response.WriteAsync("Terminal Middleware.");
        return; // Terminate, no next!
    }

    await next(context);
});

app.MapGet("/lgn", (HttpContext context, NavigationManager nm) =>
{
    //CookieOptions cookieOptions = new CookieOptions();
    //cookieOptions.Secure = false;
    //cookieOptions.Expires = DateTime.Now.AddHours(1);
    //cookieOptions.HttpOnly = true;
    //cookieOptions.SameSite = SameSiteMode.Strict;
    //context.Response.Cookies.Append("sener2", "dilara2", cookieOptions);

    //return Results.LocalRedirect("/");
    //return Results.Content("OK", "text/html");
    return Results.LocalRedirect("/", preserveMethod: true);
    //return Results.Ok();
});

app.MapGet("/colors", () =>
{
    string html = $"""
        <div id="color-demo" class="smooth" style="color:blue" hx-get="/colors" hx-swap="outerHTML" hx-trigger="every 1s">
             Color Swap Demo Blue
        </div>
    """;
    return Results.Content(html, "text/html");
});

app.MapGet("/can", () => {
    return new RazorComponentResult<Counter>();
    });


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
