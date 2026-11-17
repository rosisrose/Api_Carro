
using Carro.Contexts;
using Carro.Interface;
using Carro.Repository;
using Microsoft.EntityFrameworkCore;
using static Carro.Interface.IConcessionariaReposity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ConcessionariaContext>(options =>

        options.UseSqlServer(builder.Configuration.GetConnectionString("Concessionaria")));

builder.Services.AddScoped<IConcessionariaReposity, ConcessionariaRepository>();

  builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//app.MapGet("/api/marca", (ConcessionariaContext db) => db.Marca.ToList());
//app.MapGet("/api/veiculo", (ConcessionariaContext db) => db.Veiculo.ToList());

app.Run();
