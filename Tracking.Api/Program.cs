using Microsoft.EntityFrameworkCore;
using Reelables.Api.SDK.Api;
using System.Runtime;
using Tracking.Api;
using Tracking.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TrackingDbContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionString:TrackingDb"]));

var reelablesApiConfig = new ReelablesApiConfig
{
    BasePath = builder.Configuration["ReelablesApiConfig:BasePath"]
};

builder.Services.AddSingleton(reelablesApiConfig);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHostedService<TrackingService>();
builder.Services.AddTransient<IAssetsApi, AssetsApi>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
