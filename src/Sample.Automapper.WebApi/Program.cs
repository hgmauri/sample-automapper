using Sample.Automapper.Application;
using Sample.Automapper.Application.Application;
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