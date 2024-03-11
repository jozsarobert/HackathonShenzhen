using MassTransit;
using Microsoft.Extensions.Options;
using NeOneSync.Service;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.Configure<MessagingConfig>(builder.Configuration.GetSection("Messaging"));

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<LogisticsObjectConsumer>();

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

builder.Services.AddHostedService<Worker>();
var host = builder.Build();
host.Run();
