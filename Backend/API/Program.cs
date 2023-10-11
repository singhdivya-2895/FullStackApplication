using Data;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Application.Features.GetAll;
using FluentValidation.AspNetCore;
using FluentValidation;
using Application.Validators;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {  
       policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAllActivitiesQuery>());
builder.Services.AddAutoMapper(typeof(Application.Automapper.Mapperprofile));
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<MyValidation>();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
