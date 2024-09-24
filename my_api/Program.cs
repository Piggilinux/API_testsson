using Microsoft.EntityFrameworkCore;
using WebApplication1_API.Data;
using WebApplication1_API.Services;
//using WebApplication1_API.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add DbContext with SQLite connection string.
// This tells your application to use the SQLite
// database connection defined in appsettings.json
// and injects the AppDbContext into the service container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register DataImporter service
// builder.Services.AddScoped<DataImporter>(); // borttagen, fixade databasen separat.

builder.Services.AddControllers();

// registrera officeService, realtorservuce --> mappen Services
builder.Services.AddScoped<OfficeService>();
builder.Services.AddScoped<RealtorService>();

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


/*
 
 using Microsoft.EntityFrameworkCore;
using WebApplication1_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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
 
 */


