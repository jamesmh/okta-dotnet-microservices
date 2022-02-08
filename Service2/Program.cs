using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();

app.MapGet("/sku/{sku:required}", (string sku) => $"You're looking at SKU {sku}!");

app.Run();
