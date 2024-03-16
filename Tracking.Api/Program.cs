using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Reelables.Api.SDK.Api;
using System.Runtime;
using Tracking.Api;
using Tracking.Data;
using Tracking.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TrackingDbContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionString:TrackingDb"]));

builder.Services.AddScoped<IPieceRepository, PieceRepository>();
builder.Services.AddScoped<IPieceRepository, PieceRepository>();
builder.Services.AddScoped<IShipmentRepository, ShipmentRepository>();
builder.Services.AddScoped<IFlightRepository, FlightRepository>();
builder.Services.Configure<MessagingConfig>(builder.Configuration.GetSection("Messaging"));

builder.Services.AddMassTransit(x =>
{

    x.UsingRabbitMq((context, cfg) =>
    {
        var messagingConfig = context.GetRequiredService<IOptions<MessagingConfig>>()?.Value;

        cfg.Host(messagingConfig.Url, h =>
        {
            h.Username(messagingConfig.User);
            h.Password(messagingConfig.Password);
        });

        cfg.ConfigureEndpoints(context);

        cfg.UseNewtonsoftJsonDeserializer();
        cfg.UseNewtonsoftJsonSerializer();
    });
});

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

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
