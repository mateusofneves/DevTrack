using DevTrack.Data;
using DevTrack.Services;
using DevTrack.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Cria uma instância de ITechnologyService e a registra no contêiner de injeção de dependência
builder.Services.AddScoped<ITechnologyService, TechnologyService>();

// Leitura de configuração do banco de dados a partir do arquivo appsettings.json
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra o AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();