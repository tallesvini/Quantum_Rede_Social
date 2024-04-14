using FluentValidation.AspNetCore;
using MediatR;
using SocialQuantum.Infra.IoC.Injections;

var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddDbConnection(builder.Configuration);
builder.Services.AddInfrastructure();
builder.Services.AddDependencies();
builder.Services.AddFluentValidation();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
