using monslay_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using monslay_back;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MonSlayDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("monslaydatabase")));

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
