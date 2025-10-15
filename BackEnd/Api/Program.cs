using Api.Extensions;
using Application;
using Application.Profiles;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddDatabase(configuration);
builder.Services.AddRedisCaching(configuration);
builder.Services.AddApplicationModule();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(AutoMapping));
builder.Services.AddSwaggerDocumentation();

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
