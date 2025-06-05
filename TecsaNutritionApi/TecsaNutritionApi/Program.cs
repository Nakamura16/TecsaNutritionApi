using TecsaNutrition.Application.Services.Impl;
using TecsaNutrition.Application.Services;
using TecsaNutrition.Data.Converter;
using TecsaNutrition.Data.Converter.Impl;
using TecsaNutrition.Application.Repository;
using TecsaNutrition.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Only to test
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientConverter, PatientConverter>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();


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
