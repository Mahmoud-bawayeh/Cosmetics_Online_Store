using CosmeticsOnlineStore_Core.Context;
using CosmeticsOnlineStore_Core.Implmentations;
using CosmeticsOnlineStore_Core.Interfaces;
using Microsoft.EntityFrameworkCore;
    
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISharedInterface, SharedImplementation>();
builder.Services.AddControllers();
builder.Services.AddDbContext<CosmeticsOnlineStoreDBContext>(x =>
                x.UseSqlServer(builder.Configuration.GetConnectionString("conn")));



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
