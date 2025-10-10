using Application;
using Application.Profiles;
using Infrastructure;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddInfrastructureModule();
builder.Services.AddApplicationModule();
builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(AutoMapping));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Person Financy Api",
        Description = "",
        Contact = new OpenApiContact
        {
            Name = "Fellipe",
            Email = "fellipeep2005@gmail.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api V1");
        c.RoutePrefix = "swagger";
    });
}

app.MapControllers();

app.Run();
