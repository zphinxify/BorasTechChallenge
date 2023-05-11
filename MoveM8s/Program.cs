using MoveM8s.Data;
using MoveM8s.Client;
using MoveM8s.Interfaces;
using MoveM8s.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddScoped<ISMHIClient,SMHIClient>();
builder.Services.AddScoped<ActivityService>();
builder.Services.AddScoped<PlaygroundService>();
builder.Services.AddScoped<DogService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
