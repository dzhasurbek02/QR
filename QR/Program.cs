using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QR.Context;
using QR.Features.StaticQr;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigin", builder => builder.AllowAnyOrigin());
});

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseNpgsql("Host=localhost;Port=5432;Database=Qr;Username=postgres;Password=root"));

builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
builder.Services.AddScoped<IStaticQrService, StaticQrService>();

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