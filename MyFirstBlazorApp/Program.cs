using MyFirstBlazorApp.Components;
using MyFirstBlazorApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<GreetingService>();
//builder.Services.AddSingleton<GreetingService>();
//builder.Services.AddTransient<GreetingService>();

builder.Services.AddSingleton<TestService>(); // shared across the entire application lifetime
//builder.Services.AddScoped<TestService>(); // shared within a single user session (or scope)
//builder.Services.AddTransient<TestService>(); // a new instance is created every time it's requested

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
