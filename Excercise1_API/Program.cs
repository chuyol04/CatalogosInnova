using Excercise1_API;
using Excercise1_API.Datos;
using Excercise1_API.Repositorio;
using Excercise1_API.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//cadena de conexion db context
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Ya se podra usar mediante inyeccion de dependencias el mapping config para los modelos y sus objetos.
builder.Services.AddAutoMapper(typeof(MappingConfig));

//ya se podran utilizar los servivcios
builder.Services.AddScoped<ICatalogRepositorio, CatalogRepositorio>();

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
