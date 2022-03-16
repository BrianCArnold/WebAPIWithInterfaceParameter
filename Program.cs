using Microsoft.AspNetCore.Http.Json;
using WebAPIWithInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.Configure<JsonOptions>(opt => {
//     opt.SerializerOptions.Converters.Add(new WeatherConverter());
// });

builder.Services.AddControllers().AddJsonOptions(opt => opt.JsonSerializerOptions.Converters.Add(new IForecastConverter()));
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
