using Sample.Automapper.WebApi.Core;
using Sample.Automapper.WebApi.Core.Abstractions;
using Sample.Automapper.WebApi.Core.Application;
using Sample.Automapper.WebApi.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapperApi(typeof(MapperProfile));
builder.Services.AddScoped<IClientApplication, ClientApplication>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
