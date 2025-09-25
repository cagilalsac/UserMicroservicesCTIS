using Microsoft.EntityFrameworkCore;
using Users.APP.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the IoC container.
var connectionString = builder.Configuration.GetConnectionString(nameof(UsersDb));
builder.Services.AddDbContext<DbContext, UsersDb>(options => options.UseSqlite(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

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
