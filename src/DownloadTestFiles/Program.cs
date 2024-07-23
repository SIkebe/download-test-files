using DownloadTestFiles.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles(new StaticFileOptions
{
	ServeUnknownFileTypes = true,
	DefaultContentType = "application/octet-stream",
});

app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
