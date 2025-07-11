using APIDemoProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(5292); // this is key
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<MyDbContext>((serviceProvider, options) =>
//{
//    var config = serviceProvider.GetRequiredService<IConfiguration>();
//    options.UseSqlServer(config.GetConnectionString("MyDB"));
//});

var provider = builder.Services.BuildServiceProvider();
var config = provider.GetService<IConfiguration>();
builder.Services.AddDbContext<MyDbContext>(item => item.UseSqlServer(config.GetConnectionString("MyDB")));

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
