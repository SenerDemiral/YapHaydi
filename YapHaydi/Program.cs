using Microsoft.AspNetCore.Components;
using YapHaydi;
using YapHaydi.Components;
using YapHaydi.DataLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Configuration.AddJsonFile("C:\\AspNetConfig\\YapHaydi.json",
                       optional: true,
                       reloadOnChange: true);

builder.Services.AddSingleton<IDataAccess, FBDataAccess>();

// RootLevelCascadingValue
builder.Services.AddScoped((sp) =>
{
    var daleks = new RLCV { usrId = -1, usrName = "Tanımsız" };
    return new CascadingValueSource<RLCV>(daleks, isFixed: false);
});
// use
// @inject CascadingValueSource<RLCV> CVS
// CVS?.NotifyChangedAsync();

builder.Services.AddCascadingValue(sp => sp.GetRequiredService<CascadingValueSource<RLCV>>());
// use
// [CascadingParameter] public RLCV? rLCV { get; set; }
// rLCV.SetVal(toto.Value.usrid, "Şener");


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

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
