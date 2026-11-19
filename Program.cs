using BlazingPizza.Components;
using BlazingPizza.Services;

var builder = WebApplication.CreateBuilder(args);

// Register the services used by the interactive Blazor components.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// The menu is read-only, so one shared catalog is sufficient.
builder.Services.AddSingleton<PizzaCatalog>();

// Each visitor gets their own order while their Blazor circuit is active.
builder.Services.AddScoped<OrderState>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
