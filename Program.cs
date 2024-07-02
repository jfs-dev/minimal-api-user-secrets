var builder = WebApplication.CreateBuilder(args);
var apiKey = builder.Configuration["ApiKey"];

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => $"ApiKey: { apiKey }");

app.MapGet("/user-secrets/", () => $"ApiKey: { builder.Configuration["ApiKey"] }");

app.Run();
