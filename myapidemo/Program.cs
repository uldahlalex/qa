

using myapidemo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApiDocument();
builder.Services.AddControllers();
builder.Services.AddSingleton<PetService>();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(config => config.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()
    .SetIsOriginAllowed(_ => true));

app.MapControllers();

app.UseOpenApi();
app.UseSwaggerUi();

app.Run();
