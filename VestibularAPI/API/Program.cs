using Application.MappingProfiles;
using Application.Services;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IInscricaoRepository, InscricaoRepository>();
builder.Services.AddScoped<InscricaoService>();

builder.Services.AddScoped<IOfertaRepository, OfertaRepository>();
builder.Services.AddScoped<OfertaService>();

builder.Services.AddScoped<IProcessoSeletivoRepository, ProcessoSeletivoRepository>();
builder.Services.AddScoped<ProcessoSeletivoService>();

builder.Services.AddScoped<ILeadRepository, LeadRepository>();
builder.Services.AddScoped<LeadService>();

builder.Services.AddAutoMapper(typeof(OfertaMapper).Assembly);
builder.Services.AddAutoMapper(typeof(ProcessoSeletivoMapper).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
