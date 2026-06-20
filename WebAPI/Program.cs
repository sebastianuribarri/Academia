using Domain.Services;
using Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Register controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

// Register the required services
builder.Services.AddScoped<CursoService>();
builder.Services.AddScoped<EspecialidadService>();
builder.Services.AddScoped<PlanService>();
builder.Services.AddScoped<ComisionService>();
builder.Services.AddScoped<AlumnoService>();
builder.Services.AddScoped<DocenteService>();
builder.Services.AddScoped<MateriaService>();
builder.Services.AddScoped<InscripcionService>();
builder.Services.AddScoped<DictadoService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<PersonaService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Map routes of controllers

app.Run();
