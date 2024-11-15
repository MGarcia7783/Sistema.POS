using DB;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Crear coneccion con el contexto
builder.Services.AddDbContext<PosContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PosConnection"));
});

//Realizar llamada a la inyección
//Repository
builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<ProductoRepository>();
builder.Services.AddScoped<VentaRepository>();

//Servicie
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ProductoService>();
builder.Services.AddScoped<VentaService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PosContext>();
    context.Database.Migrate();
}

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
