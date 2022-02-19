#region Services

///////////////////////////////////////////////////////
// Application services/DI Container configures ///////
///////////////////////////////////////////////////////

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddRazorPages();
services.AddServerSideBlazor();

#endregion

#region App

///////////////////////////////////////////////////////
// Application middlewares and entrypoint /////////////
///////////////////////////////////////////////////////

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/Error");
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();

#endregion