using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;
using StudentAPI.Services;

var builder = WebApplication.CreateBuilder(args);  

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
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
