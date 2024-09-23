using Microsoft.EntityFrameworkCore;
using ReactMovieApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Access configuration from environment variables
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
var omdbApiKey = Environment.GetEnvironmentVariable("OMDB_SECRET_KEY");
var omdbBaseUrl =  Environment.GetEnvironmentVariable("BaseUrl");
// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

//configure options for OMDb API
builder.Services.Configure<OmdbAPI>(options =>
{
    options.ApiKey = omdbApiKey;
    options.BaseUrl = omdbBaseUrl;
});


builder.Services.AddControllers();
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
